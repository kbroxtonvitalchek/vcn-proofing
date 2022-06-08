using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class Identifier
   {
      public string use { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? type { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? value { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public Period? period { get; set; }

   }
}
