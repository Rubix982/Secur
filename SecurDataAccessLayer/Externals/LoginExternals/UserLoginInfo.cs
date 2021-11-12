using System;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public class UserLoginInfo
    {
        [Required]
        public string LoginProvider { get; set; }
        
        [Required]
        public string ProviderKey { get; set; }
    }
}