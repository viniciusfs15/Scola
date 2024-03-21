namespace Scola
{
  public class DisciplinaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Ementa { get; }
  }
}
