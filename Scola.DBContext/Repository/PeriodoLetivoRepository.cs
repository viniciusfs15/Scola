namespace Scola
{
  public class PeriodoLetivoRepository : ScolaBaseRepository<PeriodoLetivoEntity>
  {
    public PeriodoLetivoRepository() : base(new ScolaBaseContext()) { }
  }
}
