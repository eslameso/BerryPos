using System.Collections.Generic;

namespace Pos.Models
{
    public class Branches
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string NameA { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public ICollection<BranchesProducts> BranchesProducts { get; set; }
        public ICollection<SaleInvoices> SaleInvoices { get; set; }
        public ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public ICollection<ApplicationUsers> Users { get; set; }
    
    }
}