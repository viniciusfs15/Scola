using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class AvaliacaoRepository : ScolaBaseRepository<AvaliacaoEntity>
  {
    public AvaliacaoRepository() : base(new ScolaBaseContext()) { }
    public AvaliacaoRepository(ScolaBaseContext context) : base(context)
    {
    }
  }
}
