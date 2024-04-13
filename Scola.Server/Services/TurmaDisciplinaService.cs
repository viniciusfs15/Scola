namespace Scola
{
  public class TurmaDisciplinaService : ScolaBaseService<TurmaDisciplinaEntity>
  {
    public TurmaDisciplinaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(TurmaDisciplinaEntity entity, string message)
    {
      var turmaService = new TurmaService();
      var disciplinaService = new DisciplinaService();
      var moduloService = new ModuloService();
      var periodoLetivoService = new PeriodoLetivoService();
      var professorService = new ProfessorService();

      if (EscolaExists(entity.EscolaId) &&
          turmaService.Exists(entity.TurmaId) &&
          disciplinaService.Exists(entity.DisciplinaId) &&
          moduloService.Exists(entity.ModuloId) &&
          periodoLetivoService.Exists(entity.PeriodoLetivoId) &&
          professorService.Exists(entity.ProfessorId))
      {
        message = "Escola, Turma, Disciplina, Modulo, PeriodoLetivo ou Professor não existe(m).";
        return true;
      }
      return false;
    }
  }
}
