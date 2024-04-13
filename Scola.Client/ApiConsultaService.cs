using Scola.Client.Models;
using System.Text;

namespace Scola.Client
{
  public class ApiConsultaService
  {
    private readonly HttpClient _httpClient;

    private readonly string url = "http://localhost:7123/api/";

    public ApiConsultaService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public PageViewModel<TModel> Get<TModel>(string sufixoUrl)
    {
      using var request = new HttpRequestMessage(HttpMethod.Get, url + sufixoUrl);

      var task = Task<PageViewModel<TModel>>.Run(() => ProcessReturn<TModel>(request));
      task.Wait();

      return task.Result;
    }

    public PageViewModel<TModel> Post<TModel>(string sufixoUrl, string? payload = null)
    {
      using var request = new HttpRequestMessage(HttpMethod.Post, url + sufixoUrl);

      var task = Task<PageViewModel<TModel>>.Run(() => ProcessReturn<TModel>(request));
      task.Wait();

      return task.Result;
    }

    private async Task<PageViewModel<TModel>> ProcessReturn<TModel>(HttpRequestMessage request)
    {
      var response = _httpClient.Send(request);

      if (response.IsSuccessStatusCode)
      {
        string json = await response.Content.ReadAsStringAsync();
        PageViewModel<TModel>? pageView = Newtonsoft.Json.JsonConvert.DeserializeObject<PageViewModel<TModel>>(json);
        return pageView;
      }
      else
      {
        return default;
      }
    }
  }
}
