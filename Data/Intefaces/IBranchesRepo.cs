using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface IBranchesRepo
    {
     Task<List<Branches>> GetAllBranches();
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<Branches> GetAllBranchesSD(string SearchBar);
     void DeleteBranch(int Id);
     bool HasForegnKeyWithUser(int Id);
     bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);

      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateBranch(Branches branch);

     Branches FindBranch(int id);

     void EditBranch(Branches branche);
     

    }
}