using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public abstract class Credentials
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
    }
}