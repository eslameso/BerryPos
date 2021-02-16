using System.Collections.Generic;

namespace Pos.Models
{
    public class Stores
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductsStore> ProductsStore { get; set; }
        public ICollection<SaleInvoices> SaleInvoices { get; set; }
        public ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}