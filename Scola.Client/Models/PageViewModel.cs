namespace Scola.Client.Models
{
  public class PageViewModel<TEntity>
  {
    public bool HasNext { get; set; }
    public IEnumerable<TEntity?> Entities { get; set; }
  }
}
