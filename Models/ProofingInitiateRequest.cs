using System.Text.Json.Serialization;

namespace vcn_proofing.Models
{
   public class ProofingInitiateRequest
   {
      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? clientId { get; set; }
   }
}
