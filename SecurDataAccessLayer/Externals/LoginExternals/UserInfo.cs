using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public abstract class UserInfo
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public bool HasRegistered { get; set; }

        [Required]
        public string LoginProvider { get; set; }
    }
}