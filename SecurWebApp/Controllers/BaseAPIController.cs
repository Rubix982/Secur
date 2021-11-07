using System.Web.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Owin.Security;
using SecurWebApp.Models;

namespace SecurWebApp.Controllers
{
    public class BaseApiController : ApiController
    {
        protected readonly ApplicationDbContext Db;
        private ApplicationUserManager _userManager;

        public BaseApiController(ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            Db = new ApplicationDbContext
            {
                Users = null,
                UserClaims = null,
                UserLogins = null,
                UserTokens = null,
                UserRoles = null,
                Roles = null,
                RoleClaims = null
            };

            var store = new UserStore<ApplicationUser>(Db)
            {
                ErrorDescriber = null,
                AutoSaveChanges = false
            };

            _userManager = new ApplicationUserManager(null)
            {
                Logger = null,
                PasswordHasher = null,
                KeyNormalizer = null,
                ErrorDescriber = null,
                Options = null
            };
        }

        protected ApplicationUserManager UserManager
        {
            get => _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }
    }
}