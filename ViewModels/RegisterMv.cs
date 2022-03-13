using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Classes;
using Pos.Models;

namespace Pos.ViewModels
{
    public class RegisterMv
    {
        public RegisterMv()
        {
            Branches=new List<Branches>();
            JobTitles=new List<JobTitles>();
        }

        [Required(ErrorMessage="The User Name field is required")]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        public string EmployeeName { get; set; }

        [Required(ErrorMessage="The Email field is required")]
        [EmailAddress]
        [Display(Name="Email")]
        [ValideEmailDomain(AllowedDomain:"pos.com",ErrorMessage="Domain Name Should be (pos.com)")]
        [Remote(action:"IsEmailInUse",controller:"Account")]
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

        [Required(ErrorMessage="Branch Required")]
        [Display(Name="Branch")]
        public int BranchId { get; set; }

        [Display(Name="JobTitle")]
        public int? JobtitleId { get; set; }

        [Display(Name="Notes")]
        public string  Notes { get; set; }

        
        [Display(Name="Photo")]
        public IFormFile Photo { get; set; }

         public IList<Branches> Branches { get; set; }
         public IList<JobTitles> JobTitles { get; set; }


         



        
        

    }
}