using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Classes;

namespace Pos.ViewModels
{
    public class RegisterMv
    {
        public RegisterMv()
        {
            Branches=new List<CustomSelectList>();
            JobTitles=new List<CustomSelectList>();
        }
        [Required(ErrorMessage="The User Name field is required")]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        public string EmployeeName { get; set; }

        [Required(ErrorMessage="The Email field is required")]
        [EmailAddress]
        [Display(Name="Email")]
        [Remote(action:"IsEmailInUse",controller:"Account")]
        [ValideEmailDomain(AllowedDomain:"pos.com",ErrorMessage="Domain Name Should be (pos.com)")]
        public string Email { get; set; }
        [Required(ErrorMessage="The Password field is required")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Required(ErrorMessage="The Confirm Password field is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Display(Name="Address")]
        public string Address { get; set; }
        [Display(Name="MobileNumber")]
        public string MobileNumber { get; set; }
        [Display(Name="Photo")]
        public string Photo { get; set; }
        [Display(Name="HireDate")]
        public DateTime HireDate { get; set; }
        [Display(Name="BirthDate")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage="NationalNumber Required")]
        [Display(Name="National Number")]
        public int NationalNumber { get; set; }
         [Required(ErrorMessage="Branch Required")]
        [Display(Name="Branch")]
        public int? BranchId { get; set; }
         [Display(Name="JobTitle")]
        public int? JobtitleId { get; set; }

         public IList<CustomSelectList> Branches { get; set; }
         public IList<CustomSelectList> JobTitles { get; set; }


         [Display(Name="Notes")]
        public string  Notes { get; set; }



        
        

    }
}