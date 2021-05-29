using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;

namespace Pos.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _uow;
        public ProductsController(IUnitOfWork uow)
        {
            _uow = uow;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllProducts(int start=0,int length=10)
        {
            var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
            var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
            var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
            var Query=_uow.Products.GetAllProductsSD(SearchBar);

            if (Order==0)
            {
             Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Barcode) : Query.OrderByDescending(m=>m.Barcode));
            }
           else if (Order==1)
           {
            Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Name) : Query.OrderByDescending(m=>m.Name));
           }
             else if (Order==2)
            {
              Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Category.Name) : Query.OrderByDescending(m=>m.Category.Name));
             } 
           else if (Order==3)
{
           Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Descriptions) : Query.OrderByDescending(m=>m.Descriptions));
}
            var Count = Query.Count();
            var Model=Query.Skip(start).Take(length).Select(m => new 
            {
            id=m.Id,barcode=m.Barcode,name=m.Name,categoryname=m.Category.Name,descriptions=m.Descriptions
             }).ToList();
    
             return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });


        }
    }

}