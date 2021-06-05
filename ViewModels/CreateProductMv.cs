using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pos.Models;
using static Pos.Data.Classes.Utilitise;

namespace Pos.ViewModels
{
    public class CreateProductMv
    {
        public CreateProductMv(){
            Categories=new List<Category>();
        }
        public string  Name { get; set; }     
        public string NameA { get; set; }
        public string Barcode { get; set; }
        public List<Category> Categories { get; set; }
        public int CategoryId { get; set; }
        public MeasurmentType? MeasurmentTypes { get; set; }
        [Display(Name="Measurment Types")]
        public int MeasurmentTypeId { get; set; }
        [Display(Name="Sales Price")]
        public decimal SalesPrice { get; set; }
        [Display(Name="Purchase Price")]
        public decimal PurchasePrice { get; set; }
        public string Descriptions { get; set; }
        public string Notes { get; set; }
    }
}