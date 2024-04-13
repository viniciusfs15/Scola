using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class FrequenciaService : ScolaBaseService<FrequenciaEntity>
  {
    public FrequenciaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(FrequenciaEntity entity, string message)
    {
      var alunoService = new AlunoService();
      var turmaDiscService = new TurmaDisciplinaService();

      if (EscolaExists(entity.EscolaId) && alunoService.Exists(entity.AlunoId) && turmaDiscService.Exists(entity.TurmaDisciplinaId))
      {
        message = "Escola, Aluno ou TurmaDisciplina não existe!";
        return true;
      }
        
      return false;
    }
  }
}
