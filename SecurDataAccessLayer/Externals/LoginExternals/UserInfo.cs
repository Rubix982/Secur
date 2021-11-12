using System;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public class UserInfo
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public bool HasRegistered { get; set; }

        [Required]
        public string LoginProvider { get; set; }
    }
}