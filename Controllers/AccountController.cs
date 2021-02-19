using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
            
               foreach (var item in Result.Errors)
               {
                   ModelState.AddModelError("",item.Description);
               }
                   ModelState.AddModelError(string.Empty, "Invalid Register Attempt");
             
         }

         return View();
        }

         [HttpGet]
         [AllowAnonymous]
        public IActionResult Login()
        {
          return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LogimMv model)
        {
          if(ModelState.IsValid)
          {
          var User=await UserManager.FindByEmailAsync(model.Email);
           if (User !=null)
           {
               
             var Result=await SignInManager.PasswordSignInAsync(User.UserName,model.Password,model.RememberMe,false);
             if (Result.Succeeded)
             {
                return RedirectToAction("Index","Home");
             }
            
            }
            
          }
          ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
         return View();
        }

        [AcceptVerbs("Get","Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string Email){
         
         var User=await UserManager.FindByEmailAsync(Email);
         if (User ==null)
         {
             return Json(data:true);
         }
         else
         {

           return Json(data:$"This Email {Email} Is Already Exist");
         }


        }


    }
}