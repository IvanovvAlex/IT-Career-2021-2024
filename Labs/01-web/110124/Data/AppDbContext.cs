using _110124.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _110124.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Product>().HasMany(p => p.Tags).WithMany(t => t.Products);
        }
    }
}