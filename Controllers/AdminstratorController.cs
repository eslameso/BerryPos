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
    [Authorize(Roles="Admin")]
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

         
         public IActionResult GetAllUsers()
         {
             var Users= UserManager.Users.ToList();
             return View(Users);
         }

         public async Task<IActionResult> DeleteUser( string Id)
         {
            var User= await UserManager.FindByIdAsync(Id);
            if (User ==null)
            {
                ViewBag.ErrorMessage=$" There Is No Users With This Id {Id}";
                return View("NotFound");
            }
            var Result = await UserManager.DeleteAsync(User);
            if (Result.Succeeded)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }

         }

        [HttpGet]
         public async Task<IActionResult> EditUser(string id)
         {
             var User= await UserManager.FindByIdAsync(id);
              if (User ==null)
            {
                ViewBag.ErrorMessage=$" There Is No Users With This Id {id}";
                return View("NotFound");
            }
          
          var _Roles=await UserManager.GetRolesAsync(User);
          var _Claims=await UserManager.GetClaimsAsync(User);

            var Model = new EditUserMv()
            {
                Id=User.Id,
                UserName=User.UserName,
                Email=User.Email,
                MobileNumber=User.MobileNumber,
                Roles=_Roles,
                Claims=_Claims.Select(m =>m.Value).ToList()

            };
             
             return View(Model);
         }
         [HttpPost]
         public async Task<IActionResult> EditUser(EditUserMv Model)
         {
             if (ModelState.IsValid)
             {
                 
             
              var User= await UserManager.FindByIdAsync(Model.Id);
              if (User ==null)
            {
                ViewBag.ErrorMessage=$" There Is No Users With This Id {Model.Id}";
                return View("NotFound");
            }

            User.UserName=Model.UserName;
            User.Email=Model.Email;
            User.MobileNumber=Model.MobileNumber;

            var Result= await UserManager.UpdateAsync(User);
            if (Result.Succeeded)
            {
                return RedirectToAction("GetAllUsers");
            }
            else
            {
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }
            }
            else
            {
                ModelState.AddModelError("","Sorry There Is a Problem");
            }
            return View(Model);

         }

         [HttpGet]
         public async Task<IActionResult> MangeRolesOfUsers(string UserId)
         {
             ViewBag.UserId=UserId;
             var user= await UserManager.FindByIdAsync(UserId);
               if (user ==null)
            {
                ViewBag.ErrorMessage=$" There Is No Users With This Id {UserId}";
                return View("NotFound");
            }

            var Model =new List<RolesOfUserMv>();
            
            foreach (var item in RoleManager.Roles)
            {
                var ViewModel=new RolesOfUserMv(){
                    RoleId=item.Id,
                    RoleName=item.Name

                };

                if (await UserManager.IsInRoleAsync(user,item.Name))
                {
                    ViewModel.IsSelected=true;
                }else
                {
                    ViewModel.IsSelected=false;
                }
                Model.Add(ViewModel);
            }

            return View(Model);
              
         }

         [HttpPost]
         public async Task<IActionResult> MangeRolesOfUsers(List<RolesOfUserMv> Model,string UserId)
         {
            var user = await UserManager.FindByIdAsync(UserId);
             if (user ==null)
            {
                ViewBag.ErrorMessage=$" There Is No Users With This Id {UserId}";
                return View("NotFound");
            }
            var Roles = await UserManager.GetRolesAsync(user);
            var Result= await UserManager.RemoveFromRolesAsync(user,Roles);
            if (! Result.Succeeded)
            {
                ModelState.AddModelError("","Cannot Delete Roles Of User ");
                return View(Model);
            }

            Result=await UserManager.AddToRolesAsync(user,Model.Where(m =>m.IsSelected).Select(x =>x.RoleName));

           if (! Result.Succeeded)
            {
                ModelState.AddModelError("","Cannot Add Selected Roles To This User ");
                return View(Model);
            }
            
                return RedirectToAction("EditUser",new {id = user.Id});
            

         }



     
       
    }
}