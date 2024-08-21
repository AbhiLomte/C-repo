using Microsoft.EntityFrameworkCore;
using YourProjectName.Models; // Adjust the namespace according to your project

namespace YourProjectName.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; } // Add this line

        // Other DbSets for your application
    }
}
