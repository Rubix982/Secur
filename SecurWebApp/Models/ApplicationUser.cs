using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SecurWebApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public abstract class ApplicationUser : IdentityUser
    {
        public async Task<IdentityResult> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            return await manager.CreateAsync(this, authenticationType);
            // Add custom user claims here
        }

        public string MembershipNumber { get; set; }
        public byte[] SharedBarcodeSecret { get; set; }
    }
}