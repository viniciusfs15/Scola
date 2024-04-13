namespace Scola
{
  public class ScolaBaseService<TEntity> where TEntity : ScolaBaseEntity
  {
    protected IRepository<TEntity> Repository;

    public ScolaBaseService(ScolaBaseContext context)
    {
      Repository = new ScolaBaseRepository<TEntity>(context);
    }

    public virtual TEntity? Add(TEntity entity)
    {
      entity.Validate();
      var message = string.Empty;

      if (!BeforeAdd(entity, message))
        throw new Exception($"Falha ao adicionar o registro: {message}");

      Repository.Add(entity);
      
      AfterAdd(entity);
      return entity;
    }

    protected virtual void AfterAdd(TEntity entity) { }

    protected virtual bool BeforeAdd(TEntity entity, string message)
    {
      return true;
    }

    public virtual bool ValidateExist(TEntity entity)
    {
      return Repository.Exists(entity.Id);
    }

    public virtual object? Delete(TEntity entity)
    {
      if(Repository.Delete(entity))
        return "Registro apagado com sucesso";
      return "Registro não encontrado para deleção";
    }

    public virtual object? Update(TEntity entity)
    {
      var newEntity = entity.ValidateUpdate(Repository.Get(entity.Id), entity);
      if (Repository.Update(newEntity))
        return newEntity;
      return "Registro não encontrado para atualização";
    }

    public virtual TEntity? Get(int id)
    {
      return Repository.Get(id);
    }

    public virtual bool Exists(int id)
    {
      return Repository.Exists(id);
    }

    public virtual PagedView<TEntity> GetAll(int page, int pageSize, DateTime CreatedAt, DateTime UpdatedAt)
    {
      return Repository.GetAll(page, pageSize, CreatedAt, UpdatedAt);
    }

    protected bool EscolaExists(int escolaId)
    {
      var escolaService = new EscolaService();
      return escolaService.Exists(escolaId);
    }

    protected bool PessoaExists(int pessoaId)
    {
      var pessoaService = new PessoaService();
      return pessoaService.Exists(pessoaId);
    }
  }
}
