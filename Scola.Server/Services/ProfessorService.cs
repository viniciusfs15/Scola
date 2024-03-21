namespace Scola
{
  public class ProfessorService : ScolaBaseService<ProfessorEntity>
  {
    public ProfessorService() : base(new ScolaBaseContext()){ }

    protected override bool BeforeAdd(ProfessorEntity entity)
    {
      return EscolaExists(entity.EscolaId) && PessoaExists(entity.PessoaId);
    }
  }
}
