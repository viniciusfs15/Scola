using Scola;
using System.Collections.Generic;
using System.Linq;

namespace Scola
{
  public class PagedView<TEntity>
  {
    public PagedView(IEnumerable<TEntity> filteredList, int count, int? page, int? pageSize)
    {
      var _page = page == null || page == 0 ? 1 : (int)page;
      var _pageSize = pageSize == null || pageSize == 0 ? 1 : (int)pageSize;

      Entities = filteredList.Skip((_page - 1) * _pageSize).ToList();
      HasNext = GetHasNext(count, page, pageSize);
    }
    public bool HasNext { get; set; }
    public IEnumerable<TEntity?> Entities { get; set; }

    private bool GetHasNext(int count, int? page, int? pageSize)
    {
      page = page == 0 ? 1 : page;
      pageSize = pageSize == 0 ? 10 : pageSize;

      return (page * pageSize) < count;
    }
  }
}
