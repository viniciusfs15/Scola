using Microsoft.EntityFrameworkCore;

namespace Scola
{
  public class FrequenciaService : ScolaBaseService<FrequenciaEntity>
  {
    public FrequenciaService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(FrequenciaEntity entity)
    {
      var alunoService = new AlunoService();
      var turmaDiscService = new TurmaDisciplinaService();

      if (EscolaExists(entity.EscolaId) && alunoService.Exists(entity.AlunoId) && turmaDiscService.Exists(entity.TurmaDisciplinaId))
        return true;
      return false;
    }
  }
}
