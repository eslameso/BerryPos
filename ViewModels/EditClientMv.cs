using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class EditClientMv
    {
     public int Id { get; set; }
     [Required]
     [Display(Name="Client Code")]
     [Remote(action:"EditCodeValidation",controller:"Clients",AdditionalFields="Id",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="Client Name")]
     [Remote(action:"IsEditNameExist",controller:"Clients",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
       [Required(ErrorMessage="The Email field is required")]
        [EmailAddress]
        [Display(Name="Email Address")]
        // [Remote(action:"IsEmailInUse",controller:"Clients")]
        
      [Remote(action:"IsEmailInUseEdit",controller:"Clients",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Email { get; set; }
      [Required]
      [RegularExpression(@"^(?:\d{2}-\d{3}-\d{3}-\d{3}|\d{11})$", ErrorMessage = "Entered phone format is not valid.")]
      [Display(Name="Mobile Number")]
      public string MobileNumber { get; set; }
    }
}