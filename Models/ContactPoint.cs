using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class ContactPoint
   {

public string use { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string value { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public int rank { get; set; }


      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public Period period { get; set; }

   }
}
