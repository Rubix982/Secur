using System;
using System.Numerics;
using System.Web.Http;
using Microsoft.Owin.Security;
using Shared;

namespace SecurWebApp.Controllers
{
    [Authorize]
    public class BarcodeController : BaseApiController
    {
        public BarcodeController(ISecureDataFormat<AuthenticationTicket> accessTokenFormat) : base(accessTokenFormat)
        {
        }

        public BigInteger Post(requestSharedKeyBindingModel model)
        {
            var dh = new DiffieHellman();
            var key = dh.getFinalKey(BigInteger.Parse((ReadOnlySpan<char>) model.Key));

            UserManager.FindById(User.Identity.GetUserId()).SharedBarcodeSecret = key;
            Db.SaveChanges();
            return dh.GetMyPublic();
        }
    }
}