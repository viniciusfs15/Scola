
namespace Scola
{
  public class AlunoService : ScolaBaseService<AlunoEntity>
  {
    public AlunoService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(AlunoEntity entity, string message)
    {
      if(EscolaExists(entity.EscolaId) && PessoaExists(entity.PessoaId))
      {
        message = "Escola ou Pessoa não existe";
        return true;
      }
        
      return false;
    }
  }
}
