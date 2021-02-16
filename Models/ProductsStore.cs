using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class ProductsStore
    {
        
        public int ProductId { get; set; }
        
        public int SoreId { get; set; }
        [ForeignKey("ProductId")]
        public Products Product { get; set; }
        [ForeignKey("SoreId")]
        public Stores Store { get; set; }

        public int Quantity { get; set; }
        public decimal Salesprice { get; set; }
        public decimal purchaseprice { get; set; }

        public DateTime ExpireDate { get; set; }

    }
}