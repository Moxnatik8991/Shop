using Microsoft.EntityFrameworkCore;
using Shop.BackApp.Domain.Entity;
using Shop.BackApp.Helpers;
using System;
using System.Numerics;

namespace Shop.BackApp.Domain
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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FileDetails> FileDetails { get; set; }
        public DbSet<CategoryFileDetails> CategoryFileDetails { get; set; }
        public DbSet<ProductFileDetailse> ProductFileDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Categories)
                .WithOne()
                .HasPrincipalKey(e => e.Id)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Category>()
                .HasOne(_ => _.File)
                .WithOne()
                .HasPrincipalKey<Category>(_ => _.Id)
                .HasForeignKey<CategoryFileDetails>(_ => _.CategoryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasMany(_ => _.Files)
                .WithOne()
                .HasPrincipalKey(_ => _.Id)
                .HasForeignKey(_ => _.ProductId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            DateTime dateTime = DateTime.UtcNow;

            #region Generate Users

            Guid userId = Guid.NewGuid();

            string passwordSolt = PasswordHasherHelper.GenerateSalt();
            string passwordHash = PasswordHasherHelper.ComputeHash("qwe123", passwordSolt);

            List<User> users = new List<User>()
            {
                new User { Id = userId, FirstName = "Admin", LastName = "Admin", Email = "admin@admin.com", PasswordSalt = passwordSolt, PasswordHash = passwordHash, DataCreate = dateTime.AddDays(-15), DataUpdate = dateTime.AddDays(-10) }
            };

            #endregion

            #region Generate Catigories

            Guid categoryId1 = Guid.NewGuid();
            Guid categoryId2 = Guid.NewGuid();

            Guid categoryId01 = Guid.NewGuid();
            Guid categoryId02 = Guid.NewGuid();

            List<Category> categories = new List<Category>()
            {
                new Category { Id = categoryId1, Name = "Ноутбуки и компьютеры", CategoryId = null,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Ноутбуки", CategoryId = categoryId1,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Компьютеры", CategoryId = categoryId1,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Мониторы", CategoryId = categoryId1,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Планшеты", CategoryId = categoryId1,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = categoryId2, Name = "Компьютерные комплектующие", CategoryId = categoryId1,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Материнские платы", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Процессоры", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Оперативная память", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Видеокарты", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Звуковые карты", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Жесткие диски", CategoryId = categoryId2,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },

                new Category { Id = categoryId01, Name = "Смартфоны, ТВ и Электроника", CategoryId = null,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Мобильные телефоны", CategoryId = categoryId01,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Телевизоры", CategoryId = categoryId01,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = Guid.NewGuid(), Name = "Наушники и аксессуары", CategoryId = categoryId01,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                    new Category { Id = categoryId02, Name = "Носимые гаджеты", CategoryId = categoryId01,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Смарт-часы", CategoryId = categoryId02,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "3D и VR очки", CategoryId = categoryId02,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Фитнес-браслеты", CategoryId = categoryId02,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                        new Category { Id = Guid.NewGuid(), Name = "Смарт-кольца", CategoryId = categoryId02,  DataCreate = dateTime.AddDays(-14), DataUpdate = dateTime.AddDays(-10) },
                  

            };

            #endregion

            #region Generate Products

            Random random = new Random();
            Func<Guid> getRandomCategoryId = () =>
            {
                int randomIndex = random.Next(categories.Count);
                return categories[randomIndex].Id;
            };

            List<Product> products = new List<Product>()
            {
                new Product { Id = Guid.NewGuid(), Name = "Lamp", Description = "Burns for 10 hours", Price = 11.11m, UserId = userId, CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-2).AddHours(-14) },
                new Product { Id = Guid.NewGuid(), Name = "Slippers", Description = "Rubber under your foot", Price = 11.11m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-2), DataUpdate = dateTime.AddDays(-5).AddHours(-9) },

                new Product { Id = Guid.NewGuid(), Name = "Name1", Description = "Description1", Price = 1.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-1), DataUpdate = dateTime.AddDays(-1).AddHours(-1) },
                new Product { Id = Guid.NewGuid(), Name = "Name2", Description = "Description2", Price = 2.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-2), DataUpdate = dateTime.AddDays(-2).AddHours(-2) },
                new Product { Id = Guid.NewGuid(), Name = "Name3", Description = "Description3", Price = 3.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-3), DataUpdate = dateTime.AddDays(-3).AddHours(-3) },
                new Product { Id = Guid.NewGuid(), Name = "Name4", Description = "Description4", Price = 4.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-4), DataUpdate = dateTime.AddDays(-4).AddHours(-4) },
                new Product { Id = Guid.NewGuid(), Name = "Name5", Description = "Description5", Price = 5.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-5), DataUpdate = dateTime.AddDays(-5).AddHours(-5) },
                new Product { Id = Guid.NewGuid(), Name = "Name6", Description = "Description6", Price = 6.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-6), DataUpdate = dateTime.AddDays(-6).AddHours(-6) },
                new Product { Id = Guid.NewGuid(), Name = "Name7", Description = "Description7", Price = 7.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-7), DataUpdate = dateTime.AddDays(-7).AddHours(-7) },
                new Product { Id = Guid.NewGuid(), Name = "Name8", Description = "Description8", Price = 8.99m, UserId = userId,  CategoryId = getRandomCategoryId(), DataCreate = dateTime.AddDays(-8), DataUpdate = dateTime.AddDays(-6).AddHours(-8) }
            };

            #endregion

            modelBuilder.Entity<User>().HasData(
                users
            );

            modelBuilder.Entity<Category>().HasData(
                categories
            );

            modelBuilder.Entity<Product>().HasData(
                products
            );
        }
    }
}
