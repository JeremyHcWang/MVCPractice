using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterface;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class OrderRepository : BaseRepository<Order> , IOrderRepository
{
    public OrderRepository(OnlineShopDbContext sdb) : base(sdb)
    {
        
    }
}