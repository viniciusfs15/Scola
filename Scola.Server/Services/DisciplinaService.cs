namespace Scola
{
  public class DisciplinaService : ScolaBaseService<DisciplinaEntity>
  {
    public DisciplinaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(DisciplinaEntity entity, string message)
    {
      if (EscolaExists(entity.EscolaId))
        return true;
      return false;
    }
  }
}
