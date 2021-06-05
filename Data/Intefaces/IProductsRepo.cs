using System.Collections.Generic;
using Pos.Models;

namespace Pos.Data.Intefaces
{
    public interface IProductsRepo
    {
        List<Products> GetAllProducts();
        IEnumerable<Products> GetAllProductsSD(string SearchBar);
        void CreateProduct(Products product);
        int GetMainMeasurments(int MeasurmnetType);
    }
}