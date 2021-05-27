using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Models
{
 public class Products
 {
 
   public int Id { get; set; }
   public string Name { get; set; }
   public string NameA { get; set; }
  //  public decimal SalesPrice { get; set; }
  //   public decimal PurchasePrice { get; set; }
   public string Barcode { get; set; }
   public string Photo { get; set; }

   public int CategoryId { get; set; }
   [ForeignKey("CategoryId")]
   public Category Category { get; set; }
   public string Rack { get; set; }
   public string Coulmn { get; set; }
   public string Cell { get; set; }
   public string Place { get; set; }
   public string Notes { get; set; }

   public ICollection<ProductsStore> ProductsStore { get; set; }
   public ICollection<BranchesProducts> BranchesProducts { get; set; }
   public ICollection<SaleInvoices> SaleInvoices { get; set; }
   public ICollection<ProductsMeasurments> ProductsMeasurments { get; set; }
   public ICollection<TransformationInvoices> TransformationInvoices { get; set; }


 }


}