namespace Scola
{
  public class TurmaService : ScolaBaseService<TurmaEntity>
  {
    public TurmaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(TurmaEntity entity, string message)
    {
      var periodoLetivoService = new PeriodoLetivoService();
      if (EscolaExists(entity.EscolaId) && periodoLetivoService.Exists(entity.PeriodoLetivoId))
      {
        message = "Escola ou PeriodoLetivo não existe(m).";
        return true;
      }
      return false;
    }
  }
}
