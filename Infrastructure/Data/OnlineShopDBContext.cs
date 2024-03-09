using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class OnlineShopDbContext:DbContext
{   
    public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : base(options)
    {

    }

    public DbSet<Shipper> Shippers { get; set; }
}