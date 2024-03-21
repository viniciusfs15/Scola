using System.ComponentModel.DataAnnotations;

namespace Scola
{
  public class PessoaEntity : ScolaBaseEntity
  {
    [Validate]
    [Required(ErrorMessage = "Informe o nome")]
    [CanUpdate]
    public string Nome { get; set; }

    [CanUpdate]
    public string Email { get; set; }

    [CanUpdate]
    public string Telefone { get; set; }

    [CanUpdate]
    public string Celular { get; set; }

    [CanUpdate]
    public string sexo { get; set; }
    [CanUpdate]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "Informe o CPF")]
    [CanUpdate]
    public string Cpf { get; set; }

    [CanUpdate]
    public string Rg { get; set; }

    [CanUpdate]
    public string OrgaoEmissor { get; set; }

    [CanUpdate]
    public DateTime DataEmissao { get; set; }

    [CanUpdate]
    public string EstadoCivil { get; set; }

    [CanUpdate]
    public EscolaridadeAlunoEnum Escolaridade { get; set; }

    [CanUpdate]
    public string CEP { get; set; }

    [CanUpdate]
    public string Endereco { get; set; }

    [CanUpdate]
    public int Numero { get; set; }
    
    [CanUpdate]
    public string Complemento { get; set; }
    
    [CanUpdate]
    public string Bairro { get; set; }
    
    [CanUpdate]
    public string Cidade { get; set; }
    
    [CanUpdate]
    public string UF { get; set; }
  }
}
