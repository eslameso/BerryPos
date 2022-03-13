using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class CreateStoreMv
    {
     [Required]
     [Display(Name="Store Code")]
     [Remote(action:"CreateCodeValidation",controller:"Stores",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="Store Name")]
      [Remote(action:"IsCreateNameExist",controller:"Stores",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
      
      [Display(Name="Description")]
      public string Description { get; set; }
    }

}