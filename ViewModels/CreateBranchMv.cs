using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class CreateBranchMv
    {
     [Required]
     [Display(Name="Branch Code")]
     [Remote(action:"CreateCodeValidation",controller:"Branches",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="Branch Name")]
      [Remote(action:"IsCreateNameExist",controller:"Branches",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
      [Required]
      [Display(Name="Branch Address")]
      public string Address { get; set; }
      [Display(Name="Description")]
      public string Description { get; set; }
    }

}