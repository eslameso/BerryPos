using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class CategoriesController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public CategoriesController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public IActionResult GetListOfCategories (int start=0,int length=10 )
{
var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
var Query=_uow.categories.GetAllCategoriessSD(SearchBar);

if (Order==0)
{
     Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Name) : Query.OrderByDescending(m=>m.Name));
}
else if (Order==1)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Description) : Query.OrderByDescending(m=>m.Description));
}

var Count = Query.Count();
var Model=Query.Skip(start).Take(length).Select(m => new {
m.Id,m.Name,m.Description
}
    
).ToList();

return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });

}

public IActionResult Create()
{
    return PartialView();
}

[HttpPost]
public IActionResult Create(CreateCategoryMv model)
{
    if (ModelState.IsValid)
    {
        Category category=new Category(){
           
           Name=model.Name,
           Description=model.Description
        };

        _uow.categories.CreateCategory(category);
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
public IActionResult IsCreateNameExist(string Name)
{
    return Json(_uow.categories.IsCreateNameExist(Name));
}

public IActionResult Edit(int id)
{
var Category=_uow.categories.FindCategory(id);

EditCategoryMv model=new EditCategoryMv (){
    Id=Category.Id,
    Name=Category.Name,
     Description=Category.Description
};
return PartialView(model);
}

[HttpPost]
public IActionResult Edit(EditCategoryMv model)
{

   if (ModelState.IsValid)
   {
        Category category=new Category(){
        Id=model.Id,
        Name=model.Name,
        Description=model.Description
    };
    _uow.categories.EditCategory(category);
    _uow.SaveAsync();
   }
   else
   {
     ModelState.AddModelError(string.Empty,"Invalid Edit Branch Attempt !");
   }
   return PartialView(model);

}




[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEditNameExist(string Name,int id)
{
    return Json(_uow.categories.IsEditNameExist(Name,id));
}






public IActionResult Delete(int Id)
{
    try{
        if (! HasForegnKey(Id))
        {
        _uow.categories.DeleteCategory(Id);
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

    return _uow.categories.HasForegnKeyWithProduct(id);
}


    }

}