using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Intefaces;

namespace Pos.Controllers
{
    public class BranchesController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        public BranchesController(IUnitOfWork uow)
        {
            _uow = uow;
          
        }
 public IActionResult Index()
 {
     return View();
 }
 
public async Task<IActionResult> GetListOfBranches ()
{
    var Branches=await _uow.Branches.GetAllBranches();
   
    return Json(new {data = Branches,recordsFiltered=Branches.Count(),recordsTotal=Branches.Count()});
}


    }

}