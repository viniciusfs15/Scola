namespace Scola
{
  public class ProfessorService : ScolaBaseService<ProfessorEntity>
  {
    public ProfessorService() : base(new ScolaBaseContext()){ }

    protected override bool BeforeAdd(ProfessorEntity entity, string message)
    {
      if (EscolaExists(entity.EscolaId) && PessoaExists(entity.PessoaId))
      {
        message = "Escola ou Pessoa não existe(m).";
        return true;
      }
      return false;
    }
  }
}
