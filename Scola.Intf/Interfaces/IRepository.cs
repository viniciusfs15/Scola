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
    PagedView<TEntity> GetAll(int page, int pageSize, DateTime CreatedAt, DateTime UpdatedAt);
    bool Update(TEntity entity);
  }
}
