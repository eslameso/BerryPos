using System.Collections.Generic;
using System.Security.Claims;

namespace Pos.Models
{
public static class ClaimsStore
{
  public static List<Claim> AllClaims=new List<Claim>()
  {
    new Claim ("TestClaim","TestClaim")
      
  };


}

}