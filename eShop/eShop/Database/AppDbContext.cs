using eShop.Database.Config;
using eShop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> categories { get; set; }
        public AppDbContext(DbContextOptions options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategotyConfig());
           modelBuilder.ApplyConfiguration(new ProductConfig()); 
        }
    }
}
