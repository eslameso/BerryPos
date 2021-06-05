using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

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
        public IActionResult GetAllProducts(int start=0,int length=10 )
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
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CreateProductMv Model= new CreateProductMv(){
                Categories=await _uow.categories.GetAllCategories()
            };
            return PartialView(Model);
        }
       [HttpPost]
       public async Task<IActionResult> Create(CreateProductMv Model)
       {
           if (ModelState.IsValid)
           {
            int MainMeasurment=_uow.Products.GetMainMeasurments(Model.MeasurmentTypeId);
             Products product = new Products();
                 product.Barcode=Model.Barcode;
                 product.Name=Model.Name;
                 product.CategoryId=Model.CategoryId;
                 product.Descriptions=Model.Descriptions;
                            
             product.ProductsMeasurments.Add(new ProductsMeasurments(){MeasurmentId=MainMeasurment,SalesPrice=Model.SalesPrice,PurchasePrice=Model.PurchasePrice,Description=""});
            _uow.Products.CreateProduct(product);
             await _uow.AsyncSaving();
               
           }
           else
           {
               ModelState.AddModelError(string.Empty,"Invalid Create Attempt !");
           }

         return PartialView(Model);
       }

       [HttpPost]
       public IActionResult GenerateBarCode(string value)
       {
           ViewBag.Data=value;
           return PartialView("_BarCode");
       }

    }

}