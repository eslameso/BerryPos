using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class ProductsMeasurments
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public int MeasurmentId { get; set; }
        [ForeignKey("MeasurmentId")]
        public Measurments Measurments { get; set; }
        public string Description { get; set; }
    }
}