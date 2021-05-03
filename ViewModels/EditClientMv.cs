using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class EditBranchMv
    {
     public int Id { get; set; }
    [Required]
     [Display(Name="Branch Code")]
     [Remote(action:"EditCodeValidation",controller:"Branches",AdditionalFields="Id",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="Branch Name")]
      [Remote(action:"IsEditNameExist",controller:"Branches",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
      [Required]
      [Display(Name="Branch Address")]
      public string Address { get; set; }
      [Display(Name="Description")]
      public string Description { get; set; }
    }
}