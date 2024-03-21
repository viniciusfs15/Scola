using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class DisciplinaRepository : ScolaBaseRepository<DisciplinaEntity>
  {
    public DisciplinaRepository() : base(new ScolaBaseContext()) { }
    public DisciplinaRepository(ScolaBaseContext context) : base(context)
    {
    }
  }
}
