using System.Collections.Generic;

namespace Pos.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string NameA { get; set; }
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public int OthrMobileNumber { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public ICollection<SaleInvoices> SaleInvoices { get; set; }
        
    }
}