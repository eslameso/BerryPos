using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Pos.Models
{
    public class ApplicationUsers :IdentityUser
    {
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public int OthrMobileNumber { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalNumber { get; set; }
        public string Relegion { get; set; }
         public string Notes { get; set; }
         public ICollection<SaleInvoices> SaleInvoices { get; set; }
         public ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}