using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entity;

namespace Shop.Domain
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            DateTime dateTime = DateTime.UtcNow;

            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), FirstName = "Admin", LastName = "Admin", Email = "admin@admin.com" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Lamp", Description = "Burns for 10 hours", Price = 11.11m, DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-2).AddHours(-14) },
                new Product { Id = Guid.NewGuid(), Name = "Slippers", Description = "Rubber under your foot", Price = 11.11m, DataCreate = dateTime.AddDays(-2), DataUpdate = dateTime.AddDays(-5).AddHours(-9) }
            );
        }
    }
}
