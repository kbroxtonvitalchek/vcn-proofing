using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class Organization : Subject
   {

      public Identifier identifier { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? name { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string? type { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public List<string>? alias { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public List<ContactPoint>? telecom { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public Address? address { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

      public string? assurance { get; set; }
   }
}
