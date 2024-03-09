using ApplicationCore.RepositoryInterface;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class BaseRepository<T>(OnlineShopDbContext sdb) : IRepository<T>
    where T : class
{
    private readonly OnlineShopDbContext _context = sdb;

    public int Delete(int id)
    {
        var entity = GetById(id);
        _context.Set<T>().Remove(entity);
        return  _context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return  _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return  _context.Set<T>().Find(id);
    }

    public int Insert(T entity)
    {
        _context.Set<T>().Add(entity);
        return  _context.SaveChanges();
    }

    public int Update(T entity)
    {
        _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return _context.SaveChanges();
    }
}