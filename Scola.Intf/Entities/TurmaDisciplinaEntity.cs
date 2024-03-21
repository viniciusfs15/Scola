namespace Scola
{
  public class TurmaDisciplinaEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int TurmaId { get; set; }
    [Validate]
    public int DisciplinaId { get; set; }
    [Validate]
    public int ModuloId { get; set; }
    [Validate]
    public int PeriodoLetivoId { get; set; }
    [Validate]
    public int ProfessorId { get; set; }
    public Decimal Media { get; set; }
    public Decimal Nota { get; set; }
    public Decimal Faltas { get; set; }
  }
}
