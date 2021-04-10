using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using Pos.Models;

namespace Pos.Controllers
{
     
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHtmlLocalizer<HomeController> _Localizer;
        public HomeController(ILogger<HomeController> logger,IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _Localizer=localizer;
        }
         [Authorize]
        public IActionResult Index()
        {
            var Message=_Localizer["WelcomeBerry"];
            ViewData["WelcomeBerry"]=Message;
            return View();
        }

          [HttpPost]
          public IActionResult CultureMangement(string Culture,string returnurl)
           {
             Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Culture)),
             new CookieOptions {Expires=DateTimeOffset.Now.AddDays(30) }
             );
                 
                 return LocalRedirect(returnurl);
                 
           }
         [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
