using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
    public class TransformationInvoices
    {
        public int Id { get; set; }
        public int TransformationType { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public DateTime TransformationDate { get; set; }
         public int SerialNumber { get; set; }
        
        public string AppUserID { get; set; }
        [ForeignKey("AppUserID")]
        public ApplicationUsers ApplicationUsers { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}