namespace Scola
{
  public class FrequenciaRepository : ScolaBaseRepository<FrequenciaEntity>
  {
    public FrequenciaRepository() : base(new ScolaBaseContext()) { }
  }
}
