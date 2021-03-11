using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<WineFamily> WineFamilies { get; set; }

        public DbSet<SaleOrder> SaleOrders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<Token> Tokens { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Product>()
        //     .HasOne(p => p.DefaultSupplier);
        //     .WithOne();
        // }

    }
}