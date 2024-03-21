namespace Scola
{
  public class EscolaEntity : ScolaBaseEntity
  {
    [Validate]
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string CEP { get; set; }
    public string Endereco { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string UF { get; set; }
  }
}
