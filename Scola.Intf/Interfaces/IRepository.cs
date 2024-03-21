namespace Scola
{
  public interface IRepository<TEntity> where TEntity : ScolaBaseEntity
  {
    TEntity Add(TEntity entity);
    IEnumerable<TEntity> Add(IEnumerable<TEntity> entity);
    bool Delete(TEntity entity);
    bool Exists(int id);
    bool Exists(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
    TEntity Get(int id);
    PagedView<TEntity> GetAll(Filter filter, int page, int pageSize);
    bool Update(TEntity entity);
  }
}
