using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  NameA { get; set; }
        public string Description { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}