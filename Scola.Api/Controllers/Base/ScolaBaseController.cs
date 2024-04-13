using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Scola
{
  [ApiController]
  [Route("api/[controller]")]
  public class ScolaBaseController<TEntity, TService, TRepository> : Controller
    where TEntity : ScolaBaseEntity, new()
    where TService : ScolaBaseService<TEntity>, new()
    where TRepository : ScolaBaseRepository<TEntity>, new()

  {
    public readonly TService Service = Activator.CreateInstance<TService>();

    [HttpGet("index")]
    public virtual IActionResult Index(int page = 1, int pageSize = 10, DateTime? CreatedAt = null, DateTime? ModifiedAt = null)
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

    [HttpGet]
    public virtual IActionResult Get(int id)
    {
      try
      {
        var entity = Service.Get(id);
        if (entity == null) return NotFound();
        return Ok(entity);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpPost]
    public virtual IActionResult Add([FromBody] TEntity entity)
    {
      try
      {
        Service.Add(entity);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpPut]
    public virtual IActionResult Update(TEntity entity)
    {
      try
      {
        var updatedEntity = Service.Update(entity);
        if (updatedEntity.GetType() == typeof(string)) return NotFound();
        Service.Update(entity);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpDelete]
    public virtual IActionResult Delete(TEntity entity)
    {
      try
      {
        Service.Delete(entity);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
