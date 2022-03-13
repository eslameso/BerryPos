using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class EditJobTitlesMv
    {
     public int Id { get; set; }
    [Required]
     [Display(Name="JobTitle Code")]
     [Remote(action:"EditCodeValidation",controller:"JobTitles",AdditionalFields="Id",ErrorMessage="This Code Is Already Exist .")]
      public int Code { get; set; }
      [Required]
      [Display(Name="JobTitle Name")]
      [Remote(action:"IsEditNameExist",controller:"JobTitles",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
    
      [Display(Name="Notes")]
      public string Notes { get; set; }
    }
}