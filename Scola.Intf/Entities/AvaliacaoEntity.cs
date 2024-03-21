namespace Scola
{
  public class AvaliacaoEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Ementa { get; set; }
    public Decimal Media { get; set; }
    public Decimal Nota { get; set; }
  }
}
