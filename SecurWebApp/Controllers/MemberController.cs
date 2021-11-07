using System.Web.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Owin.Security;

namespace SecurWebApp.Controllers
{
    [Authorize]
    public class MemberController : BaseApiController
    {
        public MemberController(ISecureDataFormat<AuthenticationTicket> accessTokenFormat) : base(accessTokenFormat)
        {
        }

        public string Get()
        {
            return UserManager<>.FindById(User.Identity.GetUserId()).MembershipNumber;
        }
    }
}