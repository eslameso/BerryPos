using System;
using System.Collections.Generic;

namespace Pos.ViewModels
{
    public class EditUserMv
    {
       public EditUserMv()
        {
            Roles=new List<string>();
            Claims=new List<string>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> Claims { get; set; }

        //  public string Address { get; set; }
         
        // public int OthrMobileNumber { get; set; }
        // public int Age { get; set; }
        // public string Photo { get; set; }
        // public DateTime HireDate { get; set; }
        // public DateTime BirthDate { get; set; }
        // public int NationalNumber { get; set; }
        // public string Relegion { get; set; }
      

 

    }
}