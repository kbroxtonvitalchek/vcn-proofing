using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class HumanName
   {
      public string use { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string last { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string first { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string middle { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string prefix { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string suffix { get; set; }

   }
}
