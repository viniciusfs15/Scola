namespace Scola
{
  public class TurmaService : ScolaBaseService<TurmaEntity>
  {
    public TurmaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(TurmaEntity entity)
    {
      var periodoLetivoService = new PeriodoLetivoService();
      return EscolaExists(entity.EscolaId) && periodoLetivoService.Exists(entity.PeriodoLetivoId);
    }
  }
}
