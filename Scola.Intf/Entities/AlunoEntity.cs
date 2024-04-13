using System.ComponentModel.DataAnnotations;

namespace Scola
{
  public class AlunoEntity : ScolaBaseEntity
  {
    [Validate]
    [Display(Name = "Código Pessoa")]
    public int PessoaId { get; set; }
    [Validate]
    [Display(Name = "Código Escola")]
    public int EscolaId { get; set; }
  }
}
