using vcn_proofing.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static vcn_proofing.Enums.ProofingCodes;

namespace vcn_proofing
{
   public class StepRun
   {

      public ProofingStepCode stepCode { get; set; }

      [JsonIgnore]
      public ProofingStepStatus status { get; set; } = ProofingStepStatus.Initiate;

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public List<string>? errorMessages { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? url { get; set; } = string.Empty;

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public int? expiry { get; set; }

      [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
      public string? pin { get; set; }

      public long vcId { get; set; }


      public string proofingStepStatus
      {
         get { return status.ToString(); }
         set { status = Enum.Parse<ProofingStepStatus>(value ?? ProofingStepStatus.Initiate.ToString()); }
      }
   }
}
