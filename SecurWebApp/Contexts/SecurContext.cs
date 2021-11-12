using SecurDataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace SecurWebApp.Contexts
{
    public class SecurContext : DbContext
    {
        public SecurContext(DbContextOptions<SecurContext> options) : base(options) {}
        
        public DbSet<User> User { get; set; }
    }
}