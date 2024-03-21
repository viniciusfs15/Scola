namespace Scola
{
  public class Filter
  {
    public Dictionary<string, object?> Filters { get; } = new Dictionary<string, object?>();

    public void AddFilters(string key, object? value)
    {
      Filters.Add(key, value);
    }

    public Filter(Dictionary<string, object?> filters)
    {
      Filters = filters;
    }
  }
}
