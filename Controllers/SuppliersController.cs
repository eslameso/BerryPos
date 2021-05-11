using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class SuppliersController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public SuppliersController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public IActionResult GetListOfSuppliers (int start=0,int length=10 )
{
var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
var Query=_uow.Suppliers.GetAllSuppliersSD(SearchBar);

if (Order==0)
{
     Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Code) : Query.OrderByDescending(m=>m.Code));
}
else if (Order==1)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Name) : Query.OrderByDescending(m=>m.Name));
}
else if (Order==2)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Email) : Query.OrderByDescending(m=>m.Email));
}
else if (Order==3)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.MobileNumber) : Query.OrderByDescending(m=>m.MobileNumber));
}
var Count = Query.Count();
var Model=Query.Skip(start).Take(length).Select(m => new {
m.Id,m.Code,m.Name,m.Email,m.MobileNumber
}
    
).ToList();

return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });

}

public IActionResult Create()
{
    return PartialView();
}

[HttpPost]
public IActionResult Create(CreateSupplierMv model)
{
    if (ModelState.IsValid)
    {
        Suppliers Supplier=new Suppliers(){
           Code=model.Code,
           Name=model.Name,
           Email=model.Email,
           MobileNumber=model.MobileNumber
        };

        _uow.Suppliers.CreateSupplier(Supplier);
        _uow.SaveAsync();

    }
    else
    {
        ModelState.AddModelError(string.Empty,"Invalid Create Attempt");
       
     }
     return PartialView(model);

}
[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult CreateCodeValidation(int Code)
{
    return Json(_uow.Suppliers.IsCreateCodeExist(Code));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsCreateNameExist(string Name)
{
    return Json(_uow.Suppliers.IsCreateNameExist(Name));
}

public IActionResult Edit(int id)
{
var Supplier=_uow.Suppliers.FindSupplier(id);

EditSupplierMv model=new EditSupplierMv (){
    Id=Supplier.Id,
    Code=Supplier.Code,
    Name=Supplier.Name,
    Email=Supplier.Email,
    MobileNumber=Supplier.MobileNumber
};
return PartialView(model);
}

[HttpPost]
public IActionResult Edit(EditSupplierMv model)
{

   if (ModelState.IsValid)
   {
        Suppliers Supplier=new Suppliers(){
        Id=model.Id,
        Code=model.Code,
        Name=model.Name,
        Email=model.Email,
        MobileNumber=model.MobileNumber
    };
    _uow.Suppliers.EditSupplier(Supplier);
    _uow.SaveAsync();
   }
   else
   {
     ModelState.AddModelError(string.Empty,"Invalid Edit Supplier Attempt !");
   }
   return PartialView(model);

}


[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult EditCodeValidation(int Code,int id)
{
    return Json(_uow.Suppliers.IsEditCodeExist(Code,id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEditNameExist(string Name,int id)
{
    return Json(_uow.Suppliers.IsEditNameExist(Name,id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEmailInUseEdit(string Email,int Id)
{
    return Json(_uow.Suppliers.IsEmailInUseEdit(Email,Id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEmailInUse(string Email)
{
    return Json(_uow.Suppliers.IsEmailInUse(Email));
}




public IActionResult Delete(int Id)
{
    try{
        if (! HasForegnKey(Id))
        {
        _uow.Suppliers.DeleteSupplier(Id);
        _uow.SaveAsync();
         return Json(true);
        }
        else
        {
            return Json(false);
        }
         
    }
    catch{
        return Json(false);
    }
 
}

public bool HasForegnKey(int id)
{

    return _uow.Suppliers.HasForegnKeyWithPurchaseInvoice(id);
}


    }

}