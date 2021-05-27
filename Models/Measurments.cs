using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pos.Models
{
    public class Measurments
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public string NameA { get; set; }
      public int MeasurmentType { get; set; }
      public decimal Amount { get; set; }
      public string Description { get; set; }
      public bool IsKnow { get; set; }
      public bool IsMain { get; set; }
      public ICollection<ProductsMeasurments> ProductsMeasurments { get; set; }

    }
}