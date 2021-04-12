using System.Collections.Generic;

namespace Pos.Models
{
    public class JobTitles
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string  Name { get; set; }
        public string  NameA { get; set; }
        public string Notes { get; set; }
        public ICollection<ApplicationUsers> Users { get; set; }
    }
}