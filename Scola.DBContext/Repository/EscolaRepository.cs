using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class EscolaRepository : ScolaBaseRepository<EscolaEntity>
  {
    public EscolaRepository() : base(new ScolaBaseContext()) { }
    public EscolaRepository(ScolaBaseContext context) : base(context)
    {
    }
  }
}
