using System;
using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class Period
   {
      public DateTime start { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public DateTime? end { get; set; }
   }
}
