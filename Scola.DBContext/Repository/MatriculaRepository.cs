namespace Scola
{
  public class MatriculaRepository : ScolaBaseRepository<MatriculaEntity>
  {
    public MatriculaRepository() : base(new ScolaBaseContext()) { }
  }
}
