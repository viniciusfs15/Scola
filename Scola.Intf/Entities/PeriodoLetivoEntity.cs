namespace Scola
{
  public class PeriodoLetivoEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
  }
}
