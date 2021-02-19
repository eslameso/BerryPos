using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class RegisterMv
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        [Remote(action:"IsEmailInUse",controller:"Account")]
        [ValideEmailDomain(AllowedDomain:"pos.com",ErrorMessage="Domain Name Should be (pos.com)")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }
        

    }
}