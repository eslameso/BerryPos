using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewModels
{
    public class EditCategoryMv
    {
     public int Id { get; set; }
    
      [Required]
      [Display(Name="Category Name")]
      [Remote(action:"IsEditNameExist",controller:"Categories",AdditionalFields="Id",ErrorMessage="This Name Is Already Exist .")]
      public string Name { get; set; }
     
      [Display(Name="Description")]
      public string Description { get; set; }
    }
}