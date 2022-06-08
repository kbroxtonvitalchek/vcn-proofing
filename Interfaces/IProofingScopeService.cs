
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcn_proofing.DataHolder;

namespace vcn_proofing.Services.Interfaces
{
   public interface IProofingScopeService
   {
      Task<DHProofingScope> InitiateProofing(string clientId);
      Task<DHProofingScope> GetProofingScope(Guid conversationId);
      Task<DHProofingScope> RunProofingStepsForScope(DHProofingScope dhProofingScope, ProofingRequest proofingRequest);
   }
}
