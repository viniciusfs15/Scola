namespace Scola
{
  public class MatriculaService : ScolaBaseService<MatriculaEntity>
  {
    public MatriculaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(MatriculaEntity entity, string message)
    {
      var alunoService = new AlunoService();
      var turmaService = new TurmaService();
      var professorService = new ProfessorService();
      var periodoLetivoService = new PeriodoLetivoService();

      if (EscolaExists(entity.EscolaId) &&
         alunoService.Exists(entity.AlunoId) &&
         turmaService.Exists(entity.TurmaId) &&
         professorService.Exists(entity.ProfessorId) &&
         periodoLetivoService.Exists(entity.PeriodoLetivoId))
      {
        message = "Escola, Aluno, Turma, Professor ou PeriodoLetivo não existe(m).";
        return true;
      }       

      return false;
    }
  }
}
