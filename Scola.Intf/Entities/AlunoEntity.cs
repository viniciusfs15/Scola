using System.ComponentModel.DataAnnotations;

namespace Scola
{
  public class AlunoEntity : ScolaBaseEntity
  {
    [Validate]
    public int PessoaId { get; set; }
    [Validate]
    public int EscolaId { get; set; }
  }
}
