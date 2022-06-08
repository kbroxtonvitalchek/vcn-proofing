using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class Address
   {
      public string use { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string line1 { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string line2 { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string city { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string county { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string state { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string postalCode { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string country { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public Period period { get; set; }
   }
}
