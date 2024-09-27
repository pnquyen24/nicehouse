using Microsoft.EntityFrameworkCore;
using NiceHouse.Models;

namespace NiceHouse
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasMany(p => p.Images).WithOne(i => i.Product).HasForeignKey(i => i.ProductId);
            modelBuilder.Entity<Images>().HasOne(i => i.Product).WithMany(p => p.Images).HasForeignKey(i => i.ProductId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
