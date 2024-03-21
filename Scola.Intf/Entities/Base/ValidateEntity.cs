using System.Text;

namespace Scola
{
  public class ValidateEntity
  {
    private string BuildErrorMessage(List<string> list)
    {
      var erro = new StringBuilder();
      if (list.Count() > 0)
      {
        list.ForEach(x =>
        {
          erro.AppendLine("O campo '" + x + "' não deve ser nulo ou vazio.");
        });
      }
      return erro.ToString();
    }

    protected List<string> ReturnListPropWithError<T>(T obj)
    {
      var retorno = new List<string>();

      foreach (var prop in obj.GetType().GetProperties())
      {
        var attr = prop.GetCustomAttributes(typeof(Validate), false).FirstOrDefault();

        if (attr != null)
        {
          if (((Validate)attr).HaveDefault && prop.GetValue(obj)?.ToString() == ((Validate)attr).Default?.ToString())
          {
            retorno.Add(prop.Name);
          }
          else if (prop.GetValue(obj) == null)
          {
            retorno.Add(prop.Name);
          }
        }
      }

      return retorno;
    }

    protected string ReturnFormatedErrorMessage<T>(T obj)
    {
      return BuildErrorMessage(ReturnListPropWithError(obj));
    }

    public string Validate()
    {
      return ReturnFormatedErrorMessage(this);
    }

    public T ValidateUpdate<T>(T oldEntity, T newEntity)
    {
      var entity = (T)Activator.CreateInstance(typeof(T));

      foreach (var prop in entity.GetType().GetProperties())
      {
        var attr = prop.GetCustomAttributes(typeof(CanUpdate), false).FirstOrDefault();
        if (attr != null)
        {
          if (((CanUpdate)attr).Value)
          {
            prop.SetValue(entity, prop.GetValue(newEntity));
          }
          else
          {
            prop.SetValue(entity, prop.GetValue(oldEntity));
          }
        }
      }
      return entity;
    }
  }
}