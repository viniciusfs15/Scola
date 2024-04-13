using Microsoft.AspNetCore.Mvc;
using Scola.Client;
using Scola.Client.Models;

public class BaseController<TModel> : Controller
{
  private readonly ApiConsultaService _apiConsultaService = new ApiConsultaService(new HttpClient());

  public PageViewModel<TModel> Index(int? page, int? pageSize, string contollerName)
  {
    return _apiConsultaService.Get<TModel>($"{contollerName}/index?page={page}&pageSize={pageSize}");
  }
}