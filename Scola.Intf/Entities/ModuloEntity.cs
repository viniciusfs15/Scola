namespace Scola
{
  public class ModuloEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
  }
}
