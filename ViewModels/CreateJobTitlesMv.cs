using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class CreateJobTitlesMv
    {
     [Required]
     [Display(Name="JobTitle Code")]
     [Remote(action:"CreateCodeValidation",controller:"JobTitles",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="JobTitle Name")]
      [Remote(action:"IsCreateNameExist",controller:"JobTitles",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
      
      [Display(Name="Notes")]
      public string Notes { get; set; }
    }

}