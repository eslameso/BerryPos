using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUsers> UserManager { get; }
        public SignInManager<ApplicationUsers> SignInManager { get; }
        
        private readonly IHtmlLocalizer<AccountController> _Localizer;


        public AccountController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager,IHtmlLocalizer<AccountController> localizer)
        {
            this.SignInManager = signInManager;
            _Localizer = localizer;
            this.UserManager = userManager;

        }

//ToDo Show Register Page
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }


//ToDo Register Person To Can Login To The System
        [HttpPost]
        public async Task<IActionResult> Register(RegisterMv model){
         if (ModelState.IsValid)
         {

           var User =new ApplicationUsers{
              UserName=model.UserName,
              EmployeeName=model.EmployeeName,
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
        //ToDo Show Login Page
         [HttpGet]
         [AllowAnonymous]
        public IActionResult Login()
        {
          return View();
        }

        //ToDo Login To The System
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LogimMv model,string ReturnUrl="")
        {
          if(ModelState.IsValid)
          {
            //To Get The User That Login And Use It`s UserName To Login Becouse WE Login With Email Not User Name
            //And The PasswordSignInAsyn Need UserName
          var User=await UserManager.FindByEmailAsync(model.Email);
           if (User !=null)
           {
               
             var Result=await SignInManager.PasswordSignInAsync(User.UserName,model.Password,model.RememberMe,false);
             if (Result.Succeeded)
             {
               if (Url.IsLocalUrl(ReturnUrl))
                return Redirect(ReturnUrl);
               else
               return RedirectToAction("Index", "Home");
                
             }
            
            }
            
          }
          var Message=_Localizer["error"];
          ModelState.AddModelError(string.Empty,Message.Value);
         return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
        
        await SignInManager.SignOutAsync();
        return RedirectToAction("Login");

        }

        //ToDo Check If Email Is Already Exist
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

        [HttpGet]
        public IActionResult CompleteProfile()
        {
          return View();
        }

      [HttpGet]
         public IActionResult AccessDenied()
         {
             return View();
         }

    }
}