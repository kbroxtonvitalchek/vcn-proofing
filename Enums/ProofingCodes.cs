namespace vcn_proofing.Enums
{
   public class ProofingCodes
   {

      public enum ProofingStatus
      {
         Initiate,
         Pending,
         Remediation,
         Approval,
         Verified,
         Issued,
         Error
      }

      public enum ProofingStepStatus
      {
         Initiate,
         Pass,
         Remediation,
         Approval,
         Skip,
         Error,
         DoNotMatch
      }
      public enum ProofingStepCode
      {
         Identity,
         IdentityBusiness,
         Entitlement,
         Telecom,
         Device,
         Verified
      }
   }
}
