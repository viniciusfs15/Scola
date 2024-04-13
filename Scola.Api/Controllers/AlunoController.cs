using Microsoft.AspNetCore.Mvc;

namespace Scola
{
  public class AlunoController : ScolaBaseController<AlunoEntity, AlunoService, AlunoRepository>
  {
    public override IActionResult Index(int page = 1, int pageSize = 10, DateTime? CreatedAt = null, DateTime? ModifiedAt = null)
    {
      try
      {
        var created = CreatedAt ?? DateTime.MinValue;
        var modified = ModifiedAt ?? DateTime.MinValue;

        return Ok(Service.GetAll(page, pageSize, created, modified));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
        throw;
      }
    }
  }
}
