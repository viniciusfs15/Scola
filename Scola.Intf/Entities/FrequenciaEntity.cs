namespace Scola
{
  public class FrequenciaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int AlunoId { get; set; }
    [Validate]
    public int TurmaDisciplinaId { get; set; }
    [Validate]
    public bool Presente { get; set; }
    public string Justificativa { get; set; }
    [Validate]
    public DateTime DataFrequencia { get; set; }
  }
}
