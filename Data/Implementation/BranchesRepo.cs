using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class BranchesRepo : IBranchesRepo
    {
       private readonly ApplicationDbContext _db;

       public BranchesRepo(ApplicationDbContext db)
       {
         _db=db;
       }

        public async Task<List<Branches>> GetAllBranches()
        {
            return await _db.Branches.ToListAsync();
        }
    }
}