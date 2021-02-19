using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class AdminstratorController : Controller
    {
        public RoleManager<IdentityRole> RoleManager { get; }

        public AdminstratorController(RoleManager<IdentityRole> roleManager)
        {
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
               
            var Role = new IdentityRole {

                Name=model.Name
            };
   
             var Result=await RoleManager.CreateAsync(Role);
             if (Result.Succeeded)
             {
                return RedirectToAction("Index","Home");
             }
             foreach (var item in Result.Errors)
             {
                 ModelState.AddModelError("",item.Description);
             }
                }
            else
            {

                ModelState.AddModelError("","There Is Error In Your Data Please Check !");
            }
            
            return View();
        }

    }
}