using AllApp.Models;
using Microsoft.EntityFrameworkCore;
     

namespace AllApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
