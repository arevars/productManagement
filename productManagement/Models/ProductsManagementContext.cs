using Microsoft.EntityFrameworkCore;
using productManagement.Entities;

namespace productManagement.Models
{
    public class ProductsManagementContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public ProductsManagementContext(DbContextOptions<ProductsManagementContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }



    }
}

