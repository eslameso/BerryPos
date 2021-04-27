using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class BranchesRepo : IBranchesRepo
    {
       private readonly ApplicationDbContext _db;
        public UserManager<ApplicationUsers> _UserManager { get; }

       public BranchesRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public void DeleteBranch(int Id)
        {
            var Branch=_db.Branches.Find(Id);
            if (Branch !=null)
            {
                _db.Remove(Branch);
            }
            
        }

        public async Task<List<Branches>> GetAllBranches()
        {
           return await _db.Branches.ToListAsync();
        }

        public IEnumerable<Branches> GetAllBranchesSD(string SearchBar)
        {
            var Data= _db.Branches.Where(m => m.Code.ToString().Contains(SearchBar) 
            || m.Name.Contains(SearchBar) || m.Address.Contains(SearchBar) 
            || m.Description.Contains(SearchBar));
            return Data;
        }

        public bool HasForegnKeyWithUser(int Id)
        {
           var count= _db.Branches.Include(m => m.Users).FirstOrDefault(s =>s.Id==Id).Users.Count();
           if (count == 0)
           {
               return false;
           }
           else
           {
               return true;
           }
            // bool Flag=false;
            // foreach (var user in _UserManager.Users)
            // {
            //     if (user.BranchId==Id)
            //     {
            //         Flag= true;
                    
            //     }
                
            // }
            // return Flag;
        }

        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.Branches.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.Branches.Any(m => m.Name==Name));
        }

        public void CreateBranch(Branches branch)
        {
            _db.Add(branch);
        }

        public Branches FindBranch(int id)
        {
            return _db.Branches.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.Branches.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.Branches.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditBranch(Branches branche)
        {
            
            _db.Update(branche);
        }
    }
}