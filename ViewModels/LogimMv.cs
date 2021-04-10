using System.ComponentModel.DataAnnotations;

namespace Pos.ViewModels
{
    public class LogimMv
    {
        [Required(ErrorMessage="The Email Faild Is Require")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage="The Password Faild Is Require")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Display(Name="Remember Me")]
        public bool RememberMe { get; set; }
    }
}