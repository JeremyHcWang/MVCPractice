using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class OnlineShopDbContext:DbContext
{   
    public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : base(options)
    {

    }

    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}