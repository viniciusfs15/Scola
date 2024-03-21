
namespace Scola
{
  public class AlunoService : ScolaBaseService<AlunoEntity>
  {
    public AlunoService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(AlunoEntity entity)
    {
      if(EscolaExists(entity.EscolaId) && PessoaExists(entity.PessoaId))
        return true;
      return false;
    }
  }
}
