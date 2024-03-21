namespace Scola
{
  public class NotaRepository : ScolaBaseRepository<NotaEntity>
  {
    public NotaRepository() : base(new ScolaBaseContext()) { }
  }
}
