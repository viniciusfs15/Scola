namespace Scola
{
  public class TurmaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int PeriodoLetivoId { get; set; }
    [Validate]
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public StatusTurmaEnum Status { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
  }
}
