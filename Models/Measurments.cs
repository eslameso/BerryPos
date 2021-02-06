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
      public int Amount { get; set; }
      public string Description { get; set; }
      public ICollection<ProductsMeasurments> ProductsMeasurments { get; set; }

    }
}