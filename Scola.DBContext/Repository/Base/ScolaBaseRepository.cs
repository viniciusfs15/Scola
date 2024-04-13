using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Scola
{
  public class ScolaBaseRepository<TEntity> : IRepository<TEntity> where TEntity : ScolaBaseEntity
  {
    private readonly ScolaBaseContext Context;
    private readonly DbSet<TEntity> DbSet;

    public ScolaBaseRepository(ScolaBaseContext context)
    {
      Context = context;
      DbSet = context.Set<TEntity>();
    }

    public TEntity Add(TEntity entity)
    {
      DbSet.Add(entity);
      Context.SaveChanges();
      return entity;
    }

    public IEnumerable<TEntity> Add(IEnumerable<TEntity> entity)
    {
      DbSet.AddRange(entity);
      Context.SaveChanges();
      return entity;
    }

    public bool Delete(TEntity entity)
    {
      if (DbSet.Contains(entity))
      {
        DbSet.Remove(entity);
        Context.SaveChanges();
        return true;
      }
      return false;
    }

    public TEntity Get(int id)
    {
      return DbSet.Find(id);
    }

    public bool Update(TEntity entity)
    {
      if (DbSet.Contains(entity))
      {
        DbSet.Update(entity);
        Context.SaveChanges();
        return true;
      }
      return false;
    }

    public PagedView<TEntity> GetAll(int page, int pageSize, DateTime CreatedAt, DateTime UpdatedAt)
    {
      return new PagedView<TEntity>(GetFilltered(CreatedAt, UpdatedAt), DbSet.Count(), page, pageSize);
    }

    public IEnumerable<TEntity> GetFilltered(DateTime CreatedAt, DateTime UpdatedAt)
    {
      return DbSet.Where(x => x.CreatedAt >= CreatedAt || x.ModifiedAt >= UpdatedAt);
    }

    public bool Exists(int id)
    {
      return DbSet.Any(x => x.Id == id);
    }

    public bool Exists(Expression<Func<TEntity, bool>> predicate)
    {
      return DbSet.Any(predicate);
    }
  }
}
