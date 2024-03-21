using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Scola
{
  public class EscolaService : ScolaBaseService<EscolaEntity>
  {
    public EscolaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(EscolaEntity entity)
    {
      Expression<Func<EscolaEntity, bool>> predicate = x => x.Cnpj == entity.Cnpj && x.Nome.ToUpper() == entity.Nome.ToUpper();
      if (!Repository.Exists(predicate))
        return true;
      return false;
    }
  }
}
