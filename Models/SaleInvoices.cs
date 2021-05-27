using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pos.Models
{
    public class SaleInvoices
    {
        public int Id { get; set; }
        
        public string AppUserID { get; set; }
        [ForeignKey("AppUserID")]
        public ApplicationUsers ApplicationUsers { get; set; }
        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public Clients Clients { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDateTime { get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Stores Stores { get; set; }
        public string Notes { get; set; }

        public int? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branches Branches { get; set; }
    }
}