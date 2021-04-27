using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class BranchesController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public BranchesController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public IActionResult GetListOfBranches (int start=0,int length=10 )
{
var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
var Query=_uow.Branches.GetAllBranchesSD(SearchBar);

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
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Address) : Query.OrderByDescending(m=>m.Address));
}
else if (Order==3)
{
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Description) : Query.OrderByDescending(m=>m.Description));
}
var Count = Query.Count();
var Model=Query.Skip(start).Take(length).Select(m => new {
m.Id,m.Code,m.Name,m.Address,m.Description
}
    
).ToList();

return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });

}

public IActionResult Create()
{
    return PartialView();
}

[HttpPost]
public IActionResult Create(CreateBranchMv model)
{
    if (ModelState.IsValid)
    {
        Branches branches=new Branches(){
           Code=model.Code,
           Name=model.Name,
           Address=model.Address,
           Description=model.Description
        };

        _uow.Branches.CreateBranch(branches);
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
    return Json(_uow.Branches.IsCreateCodeExist(Code));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsCreateNameExist(string Name)
{
    return Json(_uow.Branches.IsCreateNameExist(Name));
}

public IActionResult Edit(int id)
{
var Branch=_uow.Branches.FindBranch(id);

EditBranchMv model=new EditBranchMv (){
    Id=Branch.Id,
    Code=Branch.Code,
    Name=Branch.Name,
    Address=Branch.Address,
    Description=Branch.Description
};
return PartialView(model);
}

[HttpPost]
public IActionResult Edit(EditBranchMv model)
{

}


[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult EditCodeValidation(int Code,int id)
{
    return Json(_uow.Branches.IsEditCodeExist(Code,id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEditNameExist(string Name,int id)
{
    return Json(_uow.Branches.IsEditNameExist(Name,id));
}






public IActionResult Delete(int Id)
{
    try{
        if (! HasForegnKey(Id))
        {
        _uow.Branches.DeleteBranch(Id);
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

    return _uow.Branches.HasForegnKeyWithUser(id);
}


    }

}