namespace Scola
{
  public class MatriculaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int AlunoId { get; set; }
    [Validate]
    public int TurmaId { get; set; }
    [Validate]
    public int ProfessorId { get; set; }
    [Validate]
    public int PeriodoLetivoId { get; set; }
    public DateTime DataMatricula { get; set; }
    public StatusMatriculaEnum Status { get; set; }
  }
}
