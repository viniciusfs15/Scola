namespace Scola
{
  public class PessoaRepository : ScolaBaseRepository<PessoaEntity>
  {
    public PessoaRepository() : base(new ScolaBaseContext()) { }
  }
}
