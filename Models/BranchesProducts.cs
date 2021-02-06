using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class BranchesProducts
    {
        
        public int BranchId { get; set; }
       
        public int ProductId { get; set; }
        [ForeignKey("BranchId")]
        public Branches Branches { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpireDate { get; set; }
        

    }
}