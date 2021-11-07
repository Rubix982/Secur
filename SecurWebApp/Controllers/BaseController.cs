using System.Web.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SecurWebApp.Models;

namespace SecurWebApp.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationUserManager _userManager;

        public BaseController()
        {
            var applicationDbContext = new ApplicationDbContext
            {
                Users = null,
                UserClaims = null,
                UserLogins = null,
                UserTokens = null,
                UserRoles = null,
                Roles = null,
                RoleClaims = null
            };
            var store = new UserStore<ApplicationUser>(null)
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
    }
}