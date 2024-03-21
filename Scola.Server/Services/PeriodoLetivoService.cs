namespace Scola
{
  public class PeriodoLetivoService : ScolaBaseService<PeriodoLetivoEntity>
  {
    public PeriodoLetivoService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(PeriodoLetivoEntity entity)
    {
      return EscolaExists(entity.EscolaId);
    }
  }
}
