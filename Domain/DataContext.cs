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
                new User { Id = Guid.NewGuid(), FirstName = "Admin", LastName = "Admin", Email = "admin@admin.com", DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-10) }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Lamp", Description = "Burns for 10 hours", Price = 11.11m, DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-2).AddHours(-14) },
                new Product { Id = Guid.NewGuid(), Name = "Slippers", Description = "Rubber under your foot", Price = 11.11m, DataCreate = dateTime.AddDays(-2), DataUpdate = dateTime.AddDays(-5).AddHours(-9) },

                new Product { Id = Guid.NewGuid(), Name = "Name1", Description = "Description1", Price = 1.99m, DataCreate = dateTime.AddDays(-1), DataUpdate = dateTime.AddDays(-1).AddHours(-1) },
                new Product { Id = Guid.NewGuid(), Name = "Name2", Description = "Description2", Price = 2.99m, DataCreate = dateTime.AddDays(-2), DataUpdate = dateTime.AddDays(-2).AddHours(-2) },
                new Product { Id = Guid.NewGuid(), Name = "Name3", Description = "Description3", Price = 3.99m, DataCreate = dateTime.AddDays(-3), DataUpdate = dateTime.AddDays(-3).AddHours(-3) },
                new Product { Id = Guid.NewGuid(), Name = "Name4", Description = "Description4", Price = 4.99m, DataCreate = dateTime.AddDays(-4), DataUpdate = dateTime.AddDays(-4).AddHours(-4) },
                new Product { Id = Guid.NewGuid(), Name = "Name5", Description = "Description5", Price = 5.99m, DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-5).AddHours(-5) },
                new Product { Id = Guid.NewGuid(), Name = "Name6", Description = "Description6", Price = 6.99m, DataCreate = dateTime.AddDays(-6), DataUpdate = dateTime.AddDays(-6).AddHours(-6) }
            );
        }
    }
}
