using System.ComponentModel.DataAnnotations;

namespace Pos.ViewModels
{
    public class LogimMv
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Display(Name="Remember Me")]
        public bool RememberMe { get; set; }
    }
}