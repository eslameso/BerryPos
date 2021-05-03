using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class JobTitlesController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public JobTitlesController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public IActionResult GetListOfJobtitles (int start=0,int length=10 )
{
var SearchBar=HttpContext.Request.Query["search[value]"].ToString();
var Order= int.Parse((HttpContext.Request.Query["order[0][column]"]));
var OrderDir=HttpContext.Request.Query["order[0][dir]"].ToString();
var Query=_uow.JobTitles.GetAllJobTitlesSD(SearchBar);

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
    Query=(OrderDir=="asc" ? Query.OrderBy(m =>m.Notes) : Query.OrderByDescending(m=>m.Notes));
}

var Count = Query.Count();
var Model=Query.Skip(start).Take(length).Select(m => new {
m.Id,m.Code,m.Name,m.Notes
}
    
).ToList();

return Json(new { data = Model, recordsFiltered = Count, recordsTotal = Count });

}

public IActionResult Create()
{
    return PartialView();
}

[HttpPost]
public IActionResult Create(CreateJobTitlesMv model)
{
    if (ModelState.IsValid)
    {
        JobTitles jobTitle=new JobTitles(){
           Code=model.Code,
           Name=model.Name,
           Notes=model.Notes
        };

        _uow.JobTitles.CreateJobTitle(jobTitle);
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
    return Json(_uow.JobTitles.IsCreateCodeExist(Code));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsCreateNameExist(string Name)
{
    return Json(_uow.JobTitles.IsCreateNameExist(Name));
}

public IActionResult Edit(int id)
{
var jobTitle=_uow.JobTitles.FindJobTitle(id);

EditJobTitlesMv model=new EditJobTitlesMv (){
    Id=jobTitle.Id,
    Code=jobTitle.Code,
    Name=jobTitle.Name,
    Notes=jobTitle.Notes
    
};
return PartialView(model);
}

[HttpPost]
public IActionResult Edit(EditJobTitlesMv model)
{

   if (ModelState.IsValid)
   {
        JobTitles jobTitle=new JobTitles(){
        Id=model.Id,
        Code=model.Code,
        Name=model.Name,
        Notes=model.Notes
    };
    _uow.JobTitles.EditJobTitle(jobTitle);
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
public IActionResult EditCodeValidation(int Code,int id)
{
    return Json(_uow.JobTitles.IsEditCodeExist(Code,id));
}

[AcceptVerbs("Get","Post")]
[AllowAnonymous]
public IActionResult IsEditNameExist(string Name,int id)
{
    return Json(_uow.JobTitles.IsEditNameExist(Name,id));
}






public IActionResult Delete(int Id)
{
    try{
        if (! HasForegnKey(Id))
        {
        _uow.JobTitles.DeleteJobTitle(Id);
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

    return _uow.JobTitles.HasForegnKeyWithUser(id);
}


    }

}