using Eshoppe.Models;
using EShoppe.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshoppe.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Books", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Clothing", DisplayOrder = 3 }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Sample Product",
                    Description = "This is a sample product description.",
                    Author = "Admin",
                    ISBN = "1234567890",
                    ListPrice = 100,
                    Price50 = 90,
                    Price100 = 80,
                    Price = 70
                },
                new Product
                {
                    Id = 2,
                    Title = "Another Product",
                    Description = "This is another product description.",
                    Author = "Admin",
                    ISBN = "0987654321",
                    ListPrice = 150,
                    Price50 = 140,
                    Price100 = 130,
                    Price = 120
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
