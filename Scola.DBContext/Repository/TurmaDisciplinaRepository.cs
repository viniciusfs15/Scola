namespace Scola
{
  public class TurmaDisciplinaRepository : ScolaBaseRepository<TurmaDisciplinaEntity>
  {
    public TurmaDisciplinaRepository() : base(new ScolaBaseContext()) { }
  }
}
