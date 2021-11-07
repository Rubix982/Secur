using System;
using System.Linq;
using System.Web.Mvc;
using SecurWebApp.Models;
using Shared;

namespace SecurWebApp.Controllers
{
    public class ValidateController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Validate
        public ActionResult Check(string barcode)
        {
            if (barcode.Length != 12 + Totp.Digits || barcode.Any(delegate(char representation)
            {
                if (representation <= 0) throw new ArgumentOutOfRangeException(nameof(representation));
                return !"0123456789".Contains(representation);
            }))
                return View("NotValidFormat");

            var memberId = barcode[..12] ?? throw new ArgumentNullException(nameof(barcode));

            if (memberId == null)
                throw new ArgumentNullException(nameof(memberId))
                {
                    HelpLink = null,
                    HResult = 0,
                    Source = null
                };

            var code = barcode[12..];
            var member = UserManager.Users.FirstOrDefault<>(predicate: delegate(ApplicationUser applicationUser)
            {
                if (applicationUser == null)
                    throw new ArgumentNullException(nameof(applicationUser))
                    {
                        HelpLink = null,
                        HResult = 0,
                        Source = null
                    };
                return applicationUser.MembershipNumber.Equals(memberId);
            });
            if (member == null) return View("UnAuthorized");
            if (member.SharedBarcodeSecret == null) return View("UnAuthorized");

            var totp = new Totp(member.SharedBarcodeSecret);

            return totp.ConfirmCode(code) ? View("Authorized", member) : View("UnAuthorized");
        }
    }
}