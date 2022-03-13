using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class ProductsRepo : IProductsRepo
    {
        private readonly ApplicationDbContext _db;
        public ProductsRepo(ApplicationDbContext db)
        {
            _db = db;

        }

        public void CreateProduct(Products product)
        {
            _db.Products.Add(product);
        }

        public List<Products> GetAllProducts()
        {
          return _db.Products.ToList();
        }

        public IEnumerable<Products> GetAllProductsSD(string SearchBar)
        {
           var Data=_db.Products.Include(z=>z.Category).Where(m=>m.Name.Contains(SearchBar) 
           || m.Barcode.Contains(SearchBar) || m.Category.Name.Contains(SearchBar));
           
           return Data;
        } 

        public int GetMainMeasurments(int MeasurmnetType)
        {
            return _db.Measurments.Where(m=>m.MeasurmentType==MeasurmnetType && m.IsMain==true).Select(m=>m.Id).FirstOrDefault();
        }
    }
}