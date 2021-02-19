using System.ComponentModel.DataAnnotations;

namespace Pos.ViewModels
{
    public class CreateRoleMv
    {
            [Required]
            public string  Name { get; set; }
    }
} 