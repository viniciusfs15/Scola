namespace Scola
{
  public class PeriodoLetivoService : ScolaBaseService<PeriodoLetivoEntity>
  {
    public PeriodoLetivoService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(PeriodoLetivoEntity entity, string message)
    {
      return EscolaExists(entity.EscolaId);
    }
  }
}
