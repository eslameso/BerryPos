using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    return RedirectToAction("Index", "Home");
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
     
       
    }
}