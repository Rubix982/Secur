using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public abstract class ManageInfo
    {
        [Required]
        public string LocalLoginProvider { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public IEnumerable<UserLoginInfo> Logins { get; set; }

        [Required]
        public IEnumerable<ExternalLogin> ExternalLoginProviders { get; set; }
    }
}