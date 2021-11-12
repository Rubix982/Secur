using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public abstract class UserLoginInfo
    {
        [Required]
        public string LoginProvider { get; set; }
        
        [Required]
        public string ProviderKey { get; set; }
    }
}