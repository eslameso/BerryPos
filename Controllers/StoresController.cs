using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class StoresController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public StoresController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public IActionResult GetListOfStores (int start=0,int length=10 )
{
var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
var Query=_uow.Stores.GetAllStoresSD(SearchBar);

if (Order==0)
{
     Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Code) : Query.OrderByDescending(m=>m.Code));
}
else if (Order==1)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Name) : Query.OrderByDescending(m=>m.Name));
}

else if (Order==3)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Description) : Query.OrderByDescending(m=>m.Description));
}
var Count = Query.Count();
var Model=Query.Skip(start).Take(length).Select(m => new {
m.Id,m.Code,m.Name,m.Description
}
    
).ToList();

return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });

}

public IActionResult Create()
{
    return PartialView();
}

[HttpPost]
public IActionResult Create(CreateStoreMv model)
{
    if (ModelState.IsValid)
    {
        Stores Stores=new Stores(){
           Code=model.Code,
           Name=model.Name,
           Description=model.Description
        };

        _uow.Stores.CreateStore(Stores);
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
    return Json(_uow.Stores.IsCreateCodeExist(Code));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsCreateNameExist(string Name)
{
    return Json(_uow.Stores.IsCreateNameExist(Name));
}

public IActionResult Edit(int id)
{
var Store=_uow.Stores.FindStore(id);

EditStoreMv model=new EditStoreMv (){
    Id=Store.Id,
    Code=Store.Code,
    Name=Store.Name,
    Description=Store.Description
};
return PartialView(model);
}

[HttpPost]
public IActionResult Edit(EditStoreMv model)
{

   if (ModelState.IsValid)
   {
        Stores Store=new Stores(){
        Id=model.Id,
        Code=model.Code,
        Name=model.Name,
        Description=model.Description
    };
    _uow.Stores.EditStore(Store);
    _uow.SaveAsync();
   }
   else
   {
     ModelState.AddModelError(string.Empty,"Invalid Edit Store Attempt !");
   }
   return PartialView(model);

}


[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult EditCodeValidation(int Code,int id)
{
    return Json(_uow.Stores.IsEditCodeExist(Code,id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEditNameExist(string Name,int id)
{
    return Json(_uow.Stores.IsEditNameExist(Name,id));
}






public IActionResult Delete(int Id)
{
    try{
        // if (! HasForegnKey(Id))
        // {
        _uow.Stores.DeleteStore(Id);
        _uow.SaveAsync();
         return Json(true);
        // }
        // else
        // {
        //     return Json(false);
        // }
         
    }
    catch{
        return Json(false);
    }
 
}

// public bool HasForegnKey(int id)
// {

//     return _uow.Branches.HasForegnKeyWithUser(id);
// }


    }

}