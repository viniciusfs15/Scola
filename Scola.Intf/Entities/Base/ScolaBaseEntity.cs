using System.Text.Json.Serialization;

namespace Scola
{
  public class ScolaBaseEntity : ValidateEntity, ICRUDEntityBase
  {
    [JsonPropertyOrder(0)]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedAt { get; set; }
    public string ModifiedBy { get; set; }
  }
}
