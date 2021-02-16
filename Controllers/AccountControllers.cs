using Microsoft.AspNetCore.Mvc;

namespace Pos.Controllers
{
    public class AccountController :Controller
    {
        
      [HttpGet]
      public IActionResult Register(){

        return View();
      }

    }
}