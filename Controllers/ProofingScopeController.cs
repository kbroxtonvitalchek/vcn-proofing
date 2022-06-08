using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static vcn_proofing.Enums.ProofingCodes;

namespace vcn_proofing.Controllers
{
   public class ProofingScopeController
   {

      private readonly ILogger<ProofingScopeController> _logger;
      public ProofingScopeController( ILogger<ProofingScopeController> logger)
      {

         _logger = logger;
      }


      [HttpPut, Route("{ScopeId}")]
      public async Task<ProofingResponse> RunProofing([FromRoute] Guid scopeId, [FromBody] ProofingRequest proofingRequest)
      {
       
         return new ProofingResponse(ProofingStatus.Error.ToString());
      }


      [AllowAnonymous]
      [HttpPost, Route("{ClientId}")]
      public async Task<ProofingResponse> InitiateProofing(string clientId)
      {
         return new ProofingResponse() { conversationId = Guid.NewGuid(), status = ProofingStatus.Error.ToString() };
      }

   }
}
