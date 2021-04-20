using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class EmployeesRepo : IEmployeesRepo
    {
         private readonly ApplicationDbContext _db;
        

       public EmployeesRepo(ApplicationDbContext db)
       {
         _db=db;
         
       }

       
    }
}