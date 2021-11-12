using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public abstract class ExternalLogin
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string State { get; set; }
    }
}