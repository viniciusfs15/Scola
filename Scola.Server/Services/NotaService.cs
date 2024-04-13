namespace Scola
{
  public class NotaService : ScolaBaseService<NotaEntity>
  {
    public NotaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(NotaEntity entity, string message)
    {
      var alunoService = new AlunoService();
      var turmaDiscService = new TurmaDisciplinaService();
      var avaliacaoService = new AvaliacaoService();

      if(EscolaExists(entity.EscolaId) && 
        alunoService.Exists(entity.AlunoId) && 
        turmaDiscService.Exists(entity.TurmaDisciplinaId) &&
        avaliacaoService.Exists(entity.AvaliacaoId))
      {
        message = "Escola, Aluno, TurmaDisciplina ou Avaliacao não existe(m).";
        return true;
      }

      return false;
    }
  }
}
