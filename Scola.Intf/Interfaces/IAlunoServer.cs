using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scola
{
  public interface IAlunoServer: ICRUDServer<AlunoEntity, ICRUDContext<AlunoEntity>>
  {
    PagedView<AlunoEntity> GetAll(int page, int pageSize, DateTime createdAt);
  }
}
