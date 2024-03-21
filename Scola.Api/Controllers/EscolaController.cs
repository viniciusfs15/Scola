using Microsoft.AspNetCore.Mvc;

namespace Scola.Api.Controllers
{
  public class EscolaController : ScolaBaseController<EscolaEntity, EscolaService, EscolaRepository>
  {
  }
}
