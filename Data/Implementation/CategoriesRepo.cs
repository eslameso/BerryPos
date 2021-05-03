using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class CategoriesRepo : ICategoriesRepo
    {
       private readonly ApplicationDbContext _db;
        public UserManager<ApplicationUsers> _UserManager { get; }

       public CategoriesRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public void DeleteCategory(int Id)
        {
            var category=_db.Category.Find(Id);
            if (category !=null)
            {
                _db.Remove(category);
            }
            
        }

        public async Task<List<Category>> GetAllCategories()
        {
           return await _db.Category.ToListAsync();
        }

        public IEnumerable<Category> GetAllCategoriessSD(string SearchBar)
        {
            var Data= _db.Category.Where(m => m.Name.Contains(SearchBar) 
                       || m.Description.Contains(SearchBar));
          

            return Data;
        }

        public bool HasForegnKeyWithProduct(int Id)
        {
           var count= _db.Category.Include(m => m.Products).FirstOrDefault(s =>s.Id==Id).Products.Count();
           if (count == 0)
           {
               return false;
           }
           else
           {
               return true;
           }
          
        }

        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.Branches.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.Category.Any(m => m.Name==Name));
        }

        public void CreateCategory(Category category)
        {
            _db.Add(category);
        }

        public Category FindCategory(int id)
        {
            return _db.Category.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.Branches.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.Category.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditCategory(Category category)
        {
            
            _db.Update(category);
        }

        

      
    }
}