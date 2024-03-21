namespace Scola
{
  public class AvaliacaoService : ScolaBaseService<AvaliacaoEntity>
  {
    public AvaliacaoService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(AvaliacaoEntity entity)
    {
      if(EscolaExists(entity.EscolaId))
        return true;
      return false;
    }
  }
}
