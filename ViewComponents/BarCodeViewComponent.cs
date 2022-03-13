using Microsoft.AspNetCore.Mvc;

namespace Pos.ViewComponents
{
    public class BarCodeViewComponent :ViewComponent
    {
         public IViewComponentResult Invoke()
        {
           
            return View();

        }

    }
}