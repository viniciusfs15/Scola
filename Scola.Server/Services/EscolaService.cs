using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Scola
{
  public class EscolaService : ScolaBaseService<EscolaEntity>
  {
    public EscolaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(EscolaEntity entity, string message)
    {
      Expression<Func<EscolaEntity, bool>> predicate = x => x.Cnpj == entity.Cnpj && x.Nome.ToUpper() == entity.Nome.ToUpper();
      if (!Repository.Exists(predicate))
      {
        message = "CNPJ ou Nome da Escola já existe";
        return true;
      }        
      return false;
    }
  }
}
