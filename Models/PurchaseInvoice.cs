using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class PurchaseInvoice
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        
        public string AppUserID { get; set; }
        [ForeignKey("AppUserID")]
        public ApplicationUsers ApplicationUsers { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Suppliers Suppliers { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Stores Stores { get; set; }
        public string Notes { get; set; }
        public decimal PurchasePrice { get; set; }
        
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public int? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branches Branches { get; set; }
    }
}