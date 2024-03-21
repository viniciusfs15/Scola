namespace Scola
{
  public class ProfessorEntity : ScolaBaseEntity
  {
    [Validate]
    public int EscolaId { get; set; }
    [Validate]
    public int PessoaId { get; set; }
  }
}
