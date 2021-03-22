using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class AdminstratorController : Controller
    {
        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<ApplicationUsers> UserManager { get; }

        public AdminstratorController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUsers> userManager)
        {
            this.UserManager = userManager;
            this.RoleManager = roleManager;

        }


        //ToDo Show A page Of Create A Roles 
        [HttpGet]
        public IActionResult CreateRole()
        {

            return View();
        }

        //ToDo Create Role at AspNetRole Table
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleMv model)
        {
            if (ModelState.IsValid)
            {

                var Role = new IdentityRole
                {

                    Name = model.Name
                };

                var Result = await RoleManager.CreateAsync(Role);
                if (Result.Succeeded)
                {
                    return RedirectToAction("GetAllRoles", "Adminstrator");
                }
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            else
            {

                ModelState.AddModelError("", "There Is Error In Your Data Please Check !");
            }

            return View();
        }
        //ToDo Get All Roles At The System
        [Authorize]
        [HttpGet]
        public IActionResult GetAllRoles()
        {
            var roles = RoleManager.Roles.ToList();

            return View(roles);
        }
        //ToDo Show Page Of Edit Role With Users That Belongs To This Role

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            
                var Role =await RoleManager.FindByIdAsync(id);
               
                if (Role == null)
                {
                    ViewBag.ErrorMessage= $"There Is No Role With This Id {id}";
                    return View("NotFound");
                }
               
                    var model = new EditRolesMv
                    {
                        Id = Role.Id,
                        Name = Role.Name
                    };
                    foreach (var item in UserManager.Users)
                    {
                        if (await UserManager.IsInRoleAsync(item,Role.Name))
                        {
                            model.User.Add(item.UserName);
                        }

                    }
                    
                     
                    return View(model);
                

        }
        //ToDo Edit The Role 
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRolesMv model)
        {
            
                
            var Role = await RoleManager.FindByIdAsync(model.Id);
             if (Role==null)
             {
                  ViewBag.ErrorMessage= $"There Is No Role With This Id{model.Id}";
                 return View("NotFound");
             }
             else
             {

            Role.Name=model.Name;
            var Result=await RoleManager.UpdateAsync(Role);
            if (Result.Succeeded)
            {
                return RedirectToAction("GetAllRoles");
            }
            foreach (var item in Result.Errors)
            {
                ModelState.AddModelError("",item.Description);
            } 

             }
           return View(model);
        }

         
       public async Task<ActionResult> DeleteRole(string Id)
       {
         var Role =await RoleManager.FindByIdAsync(Id);
         if (Role == null)
         {
            ViewBag.ErrorMessage= $"There Is No Role With This Id {Id}";
             return View("NotFound");
         }

             foreach (var item in UserManager.Users)
                    {
                        if (await UserManager.IsInRoleAsync(item,Role.Name))
                        {
                            return Json(false);
                        }

                    }
         var Result = await RoleManager.DeleteAsync(Role);
         if (Result.Succeeded)
         {
             return Json(true);
         }

         return Json(true);
       }

       [HttpGet]
       public async Task<IActionResult> EditUsersRole(string roleid)
       {
           var Role = await RoleManager.FindByIdAsync(roleid);
           if (Role == null)
           {
               ViewBag.ErrorMessage=$"There Is No role With This Id {roleid}";
               return View("NotFound");
           }
           ViewBag.RoleId=roleid;
            var model= new List<UsersRoleMv>();
            foreach (var user in UserManager.Users)
            {
                var usersrolemv = new UsersRoleMv
                {
                  UserId=user.Id,
                  UserName=user.UserName

                };
                if (await UserManager.IsInRoleAsync(user,Role.Name))
                {
                 usersrolemv.IsSelected=true;
                }
                else
                {
                    usersrolemv.IsSelected=false;
                }
                
                model.Add(usersrolemv);
                
            }

           

         
         return View(model);
       }

       [HttpPost]
       public async Task<IActionResult> EditUsersRole(List<UsersRoleMv> model,string roleid)
       {
           var Role= await RoleManager.FindByIdAsync(roleid);
           if (Role == null)
           {
               ViewBag.ErrorMessage=$"Ther Is No Role With This Id {roleid}";
           }
             
             for (int i = 0; i < model.Count; i++)
             {
                 var user= await UserManager.FindByIdAsync(model[i].UserId);
                 IdentityResult Result=null;
                 if (model[i].IsSelected && !(await UserManager.IsInRoleAsync(user,Role.Name)))
                 {
                     Result=await UserManager.AddToRoleAsync(user,Role.Name);
                 }
                 else if(! model[i].IsSelected && await UserManager.IsInRoleAsync(user,Role.Name))
                 {
                    Result= await UserManager.RemoveFromRoleAsync(user,Role.Name);
                 }
                 else
                 {
                     continue;
                 }

                 if (Result.Succeeded)
                 {
                     if (i < (model.Count-1))
                     continue;
                     else
                     return RedirectToAction("EditRole",new {id=roleid});
                     
                 }
             }


           return RedirectToAction("EditRole",new {id=roleid});
       }
         

     
       
    }
}