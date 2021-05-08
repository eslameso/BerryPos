using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Pos.ViewModels
{
    public class EditCompanyProfileMv
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name="Owner Name")]
        public string OwnerName { get; set; }
        [Display(Name="Company Description")]
        public string CompanyDescription { get; set; }
        [Display(Name="Company Logo")]
        public IFormFile CompanyLogo { get; set; }
        [Display(Name="Company Type")]
        public string ComapanyType { get; set; }
        [Display(Name="Notes")]
       
        public string Notes { get; set; }
    }
}