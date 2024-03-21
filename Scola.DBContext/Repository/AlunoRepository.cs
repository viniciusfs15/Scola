using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class AlunoRepository : ScolaBaseRepository<AlunoEntity>
  {
    public AlunoRepository() : base(new ScolaBaseContext()) { }
    public AlunoRepository(ScolaBaseContext context) : base(context)
    {
    }
  }
}
