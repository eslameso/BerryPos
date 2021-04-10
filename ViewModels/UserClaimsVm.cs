using System.Collections.Generic;

namespace Pos.ViewModels
{
    public class UserClaimsVm
    {
       public UserClaimsVm()
        {
            Claims=new List<UserClaims>();
        }
        public string UserId { get; set; }
        public List<UserClaims> Claims { get; set; }
        
    }



    public class UserClaims
    {

        public string ClaimType { get; set; }
        public bool IsSelected { get; set; }
    }

}