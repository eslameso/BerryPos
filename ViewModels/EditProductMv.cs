using System.Collections.Generic;
using Pos.Models;
using static Pos.Data.Classes.Utilitise;

namespace Pos.ViewModels
{
    public class EditProductMv
    {
        public EditProductMv(){
            Categories=new List<Category>();
        }
        public int Id { get; set; }
        public string  Name { get; set; }     
        public string NameA { get; set; }
        public string Barcode { get; set; }
        public List<Category> Categories { get; set; }
        public MeasurmentType MeasurmentTypes { get; set; }
        public string Descriptions { get; set; }
        public string Notes { get; set; }
    }
}