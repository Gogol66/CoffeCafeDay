using CoffeCafeDay.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeCafeDay.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<OTPModel> OTPModels { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<ProductSuppliers> ProductSuppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}