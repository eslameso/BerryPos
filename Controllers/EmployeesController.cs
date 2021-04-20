using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Controllers
{
    public class EmployeesController :Controller
    {

         public readonly UserManager<ApplicationUsers> _userManager;
        public EmployeesController(UserManager<ApplicationUsers> userManager)
        {
            _userManager=userManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployeeProfile(string Id)
        {
            var Employee =await _userManager.FindByIdAsync(Id);
            if (Employee == null)
            {
                ViewBag.ErrorMessage=$" Sorry ! There Is No Employee With This Id {Id}";
                return View("NotFound");
            }
            return View(Employee);
            
        }

    }
}