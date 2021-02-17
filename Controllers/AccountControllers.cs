using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUsers> UserManager { get; }
        public SignInManager<ApplicationUsers> SignInManager { get; }

        public AccountController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager)
        {
            this.SignInManager = signInManager;
            this.UserManager = userManager;

        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterMv model){
         if (ModelState.IsValid)
         {
           var User =new ApplicationUsers{
               UserName=model.UserName,
               Email=model.Email
           };
           var Result= await UserManager.CreateAsync(User,model.Password);
             if(Result.Succeeded)
             {
               await SignInManager.SignInAsync(User,isPersistent:false);
               return RedirectToAction("Index","Home");
             }
             else
             {
               foreach (var item in Result.Errors)
               {
                   ModelState.AddModelError("",item.Description);
               }

             }
         }

         return View();
        }

    }
}