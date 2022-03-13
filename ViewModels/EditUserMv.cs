using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pos.Models;

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
        public string EmployeeName { get; set; }
        [Remote(action:"IsEmailInUseEdit",controller:"Account",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name="Address")]
        public string Address { get; set; }

        [Display(Name="MobileNumber")]
        [RegularExpression(@"^(?:\d{2}-\d{3}-\d{3}-\d{3}|\d{11})$", ErrorMessage = "Entered phone format is not valid.")]
        public string MobileNumber { get; set; }

        [Required] 
        [Display(Name="HireDate")]
        [DataType(DataType.DateTime)]
         public DateTime HireDate { get; set; }

        [Required]
        [Display(Name="BirthDate")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage="NationalNumber Required")]
        [Display(Name="National Number")]
        [RegularExpression(@"^(?:\d{2}-\d{3}-\d{3}-\d{3}-\d{3}|\d{14})$",ErrorMessage="Entered National Number is not valid.")]
        public string NationalNumber { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> Claims { get; set; }

        [Required(ErrorMessage="Branch Required")]
        [Display(Name="Branch")]
        public int? BranchId { get; set; }

        [Display(Name="JobTitle")]
        public int? JobtitleId { get; set; }

        public IList<Branches> Branches { get; set; }
         public IList<JobTitles> JobTitles { get; set; }
         public IFormFile Image { get; set; }



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