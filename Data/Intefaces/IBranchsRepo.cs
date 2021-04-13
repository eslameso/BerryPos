using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface IBranchesRepo
    {
        Task<List<Branches>> GetAllBranches();

    }
}