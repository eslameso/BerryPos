using System.Threading.Tasks;
using Pos.Data.Intefaces;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly ApplicationDbContext _db;

       public UnitOfWork(ApplicationDbContext db)
       {
         _db=db;
       }

        public IBranchesRepo Branches => 
        new BranchesRepo(_db);

        public async Task<bool> SaveAsync()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}