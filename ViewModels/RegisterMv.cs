using System.ComponentModel.DataAnnotations;

namespace Pos.ViewModels
{
    public class RegisterMv
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }
        

    }
}