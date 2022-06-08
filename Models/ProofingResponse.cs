using vcn_proofing.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace vcn_proofing
{
   public class ProofingResponse
   {

      public ProofingResponse()
      {
      }

      public ProofingResponse(string status)
      {
         this.status = status;
      }

      public Guid conversationId { get; set; }

      public string clientId { get; set; }
      public string status { get; set; }

      public StepRun[] stepRuns { get; set; }

      
   }
}
