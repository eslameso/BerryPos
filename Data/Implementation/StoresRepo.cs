using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class StoresRepo : IStoresRepo
    {
       private readonly ApplicationDbContext _db;
        public UserManager<ApplicationUsers> _UserManager { get; }

       public StoresRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public void DeleteStore(int Id)
        {
            var Store=_db.Stores.Find(Id);
            if (Store !=null)
            {
                _db.Remove(Store);
            }
            
        }

        public async Task<List<Stores>> GetAllStores()
        {
           return await _db.Stores.ToListAsync();
        }

        public IEnumerable<Stores> GetAllStoresSD(string SearchBar)
        {
            var Data= _db.Stores.Where(m => m.Code.ToString().Contains(SearchBar) 
            || m.Name.Contains(SearchBar) 
            || m.Description.Contains(SearchBar));
            return Data;
        }

       

        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.Stores.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.Stores.Any(m => m.Name==Name));
        }

        public void CreateStore(Stores Store)
        {
            _db.Add(Store);
        }

        public Stores FindStore(int id)
        {
            return _db.Stores.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.Stores.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.Stores.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditStore(Stores Store)
        {
            
            _db.Update(Store);
        }

      
    }
}