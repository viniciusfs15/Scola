using System.ComponentModel.DataAnnotations;

namespace Scola
{
  public class PessoaEntity : ScolaBaseEntity
  {
    [Validate]
    [Required(ErrorMessage = "Informe o nome")]
    [CanUpdate]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [CanUpdate]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [CanUpdate]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }

    [CanUpdate]
    [Display(Name = "Celular")]
    public string Celular { get; set; }

    [CanUpdate]
    [Display(Name = "Sexo")]
    public string sexo { get; set; }

    [CanUpdate]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "Informe o CPF")]
    [CanUpdate]
    [Display(Name = "CPF")]
    public string Cpf { get; set; }

    [CanUpdate]
    [Display(Name = "RG")]
    public string Rg { get; set; }

    [CanUpdate]
    [Display(Name = "Orgão Emissor")]
    public string OrgaoEmissor { get; set; }

    [CanUpdate]
    [Display(Name = "Data de Emissão")]
    public DateTime DataEmissao { get; set; }

    [CanUpdate]
    [Display(Name = "Estado Civil")]
    public string EstadoCivil { get; set; }

    [CanUpdate]
    [Display(Name = "Escolaridade")]
    public EscolaridadeAlunoEnum Escolaridade { get; set; }

    [CanUpdate]
    [Display(Name = "CEP")]
    public string CEP { get; set; }

    [CanUpdate]
    [Display(Name = "Endereço")]
    public string Endereco { get; set; }

    [CanUpdate]
    [Display(Name = "Número")]
    public int Numero { get; set; }
    
    [CanUpdate]
    [Display(Name = "Complemento")]
    public string Complemento { get; set; }
    
    [CanUpdate]
    [Display(Name = "Bairro")]
    public string Bairro { get; set; }
    
    [CanUpdate]
    [Display(Name = "Cidade")]
    public string Cidade { get; set; }
    
    [CanUpdate]
    [Display(Name = "Estado")]
    public string UF { get; set; }
  }
}
