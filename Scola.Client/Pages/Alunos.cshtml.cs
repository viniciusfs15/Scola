using Microsoft.AspNetCore.Mvc.RazorPages;
using Scola.Client.Controllers;
using Scola.Client.Views;

namespace Scola.Client.Pages
{
  public class AlunosModel : PageModel
  {
    public List<AlunoView> Alunos { get; set; } = new List<AlunoView>();

    private AlunoController _alunoController = new AlunoController();

    public void OnGet()
    {
      var view = _alunoController.Index(1,10,"Aluno");
      Alunos = view.Entities.ToList();
    }
  }
}
