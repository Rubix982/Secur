using System.ComponentModel.DataAnnotations;

namespace SecurDataAccessLayer.Externals.UserExternals
{
    public abstract class UpdateUser
    {
        [Required]
        [MaxLength(100)]
        protected string Name { get; set; }

        [Required]
        [MinLength(4)]
        public string Email { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string State { get; set; }
    }
}