


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

      if (!BeforeAdd(entity))
        throw new Exception("Falha ao adicionar o registro");

      Repository.Add(entity);
      
      AfterAdd(entity);
      return entity;
    }

    protected virtual void AfterAdd(TEntity entity) { }

    protected virtual bool BeforeAdd(TEntity entity)
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

    public virtual PagedView<TEntity> GetAll(Filter filter, int page = 1, int pageSize = 10)
    {
      return Repository.GetAll(filter, page, pageSize);
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
