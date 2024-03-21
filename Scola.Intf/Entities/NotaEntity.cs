namespace Scola
{
  public class NotaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int AlunoId { get; set; }
    [Validate]
    public int TurmaDisciplinaId { get; set; }
    [Validate]
    public int AvaliacaoId { get; set; }
    [Validate]
    public decimal Nota { get; set; }
  }
}
