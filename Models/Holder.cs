using System;

namespace vcn_proofing.Models
{
   public class Holder
   {
      public string fullUrl { get; set; }

      //required mobilephone type
      public string mobilePhone { get; set; }

      public HumanName? name { get; set; }

      public Address? address { get; set; }

      //must reference CredentialSubject only
      public Link link { get; set; }
   }
}
