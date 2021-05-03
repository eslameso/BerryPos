using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class CreateCategoryMv
    {
     
      [Required]
      [Display(Name="Category Name")]
      [Remote(action:"IsCreateNameExist",controller:"Categories",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
       [Display(Name="Description")]
      public string Description { get; set; }
    }

}