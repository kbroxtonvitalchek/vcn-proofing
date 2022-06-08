
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using vcn_proofing.Models;

namespace vcn_proofing
{
   public class ProofingRequest : ProofingInitiateRequest
   {
      public Guid conversationId { get; set; }

      public string clientId { get; set; }

      public CredentialSubject credentialSubject { get; set; }

      public Holder holder { get; set; }

      public StepRun[] runSteps { get; set; }
   }
}

