using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class EditStoreMv
    {
     public int Id { get; set; }
    [Required]
     [Display(Name="Store Code")]
     [Remote(action:"EditCodeValidation",controller:"Stores",AdditionalFields="Id",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="Store Name")]
     [Remote(action:"IsEditNameExist",controller:"Stores",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
     
      [Display(Name="Description")]
      public string Description { get; set; }
    }
}