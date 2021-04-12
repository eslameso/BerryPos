using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Pos.Models
{
    public class ApplicationUsers :IdentityUser
    {
        
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string OthrMobileNumber { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalNumber { get; set; }
        public string Relegion { get; set; }
         public string Notes { get; set; }

         public int? BranchId { get; set; }
        [ForeignKey("BranchId")]
        public Branches Branches { get; set; }

        public int? JobtitleId { get; set; }
        [ForeignKey("JobtitleId")]
        public JobTitles jobTitles { get; set; }
         public ICollection<SaleInvoices> SaleInvoices { get; set; }
         public ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}