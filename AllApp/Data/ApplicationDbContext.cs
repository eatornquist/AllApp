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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, Name = "Test_Image", Address = "C:/Images", Description = "Test_Description1" },
                new Image { Id = 2, Name = "Test_Image2", Address = "C:/Images", Description = "Test_Description2" }
                );
        }
    }
}
