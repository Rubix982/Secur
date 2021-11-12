using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecurDataAccessLayer.Models
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int User_Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(4)]
        public string Email { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string State { get; set; }
    }
}