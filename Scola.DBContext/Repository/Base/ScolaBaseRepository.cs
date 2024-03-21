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

    public PagedView<TEntity> GetAll(Filter filter, int page, int pageSize)
    {
      return new PagedView<TEntity>(GetFilltered(filter), DbSet.Count(), page, pageSize);
    }

    public IEnumerable<TEntity> GetFilltered(Filter filter)
    {
      IQueryable<TEntity> query = Context.Set<TEntity>();

      foreach (var filterEntry in filter.Filters)
      {
        if (filterEntry.Value == null)
          continue;

        string key = filterEntry.Key;
        object? value = filterEntry.Value;

        // Construir a expressão lambda para filtrar os resultados com base no filtro
        ParameterExpression parameter = Expression.Parameter(typeof(TEntity));
        MemberExpression property = Expression.Property(parameter, key);
        ConstantExpression constant = Expression.Constant(value);
        BinaryExpression equal = Expression.Equal(property, constant);
        Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(equal, parameter);

        // Aplicar o filtro à consulta
        query = query.Where(lambda);
      }

      // Executar a consulta e retornar os resultados
      return query.ToList();
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
