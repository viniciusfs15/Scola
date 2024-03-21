namespace Scola
{
  public class NotaService : ScolaBaseService<NotaEntity>
  {
    public NotaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(NotaEntity entity)
    {
      var alunoService = new AlunoService();
      var turmaDiscService = new TurmaDisciplinaService();
      var avaliacaoService = new AvaliacaoService();

      if(EscolaExists(entity.EscolaId) && 
        alunoService.Exists(entity.AlunoId) && 
        turmaDiscService.Exists(entity.TurmaDisciplinaId) && 
        avaliacaoService.Exists(entity.AvaliacaoId))
        return true;

      return false;
    }
  }
}
