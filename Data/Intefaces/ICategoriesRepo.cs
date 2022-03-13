using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface ICategoriesRepo
    {
     Task<List<Category>> GetAllCategories();
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<Category> GetAllCategoriessSD(string SearchBar);
     void DeleteCategory(int Id);
     
     bool HasForegnKeyWithProduct(int Id);
     bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);

      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateCategory(Category category);

     Category FindCategory(int id);

     void EditCategory(Category category);
     

    }
}