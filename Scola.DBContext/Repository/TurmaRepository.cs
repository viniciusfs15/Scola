namespace Scola
{
  public class TurmaRepository : ScolaBaseRepository<TurmaEntity>
  {
    public TurmaRepository() : base(new ScolaBaseContext()) { }
  }
}
