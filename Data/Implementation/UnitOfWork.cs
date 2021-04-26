using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pos.Data.Intefaces;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly ApplicationDbContext _db;
         public UserManager<ApplicationUsers> _UserManager { get; }

       public UnitOfWork(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public IBranchesRepo Branches => 
        new BranchesRepo(_db,_UserManager);

        public IJobtitlesRepo JobTitles => 
        new JobtitlesRepo(_db);

        public bool SaveAsync()
        {
             return _db.SaveChanges() > 0;
        }
    }
}