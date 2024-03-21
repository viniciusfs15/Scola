namespace Scola
{
  public interface ICRUDServer<TEntity, TContext>
  {
    TContext Context { get; set; }

    TEntity? Get(int id);

    TEntity? Add(TEntity entity);

    TEntity? Update(TEntity entity);

    object? Delete(int id);

    object? Delete(TEntity entity);
    void Initialize();
  }
}
