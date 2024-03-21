using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class ProfessorRepository : ScolaBaseRepository<ProfessorEntity>, IRepository<ProfessorEntity>
  {
    public ProfessorRepository() : base(new ScolaBaseContext()) { }
    public ProfessorRepository(ScolaBaseContext context) : base(context)
    {
    }
  }
}
