using System.Linq.Expressions;

namespace Scola
{
  public class PessoaService : ScolaBaseService<PessoaEntity>
  {
    public PessoaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(PessoaEntity entity, string message)
    {
      Expression<Func<PessoaEntity, bool>> predicate = x => x.Cpf == entity.Cpf;
      if (!Repository.Exists(predicate))
      {
        message = "CPF ja existe";
        return true;
      }
      return false;
    }
  }
}
