using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface IStoresRepo
    {
     Task<List<Stores>> GetAllStores();
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<Stores> GetAllStoresSD(string SearchBar);
     void DeleteStore(int Id);
   
     bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);

      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateStore(Stores Store);

     Stores FindStore(int id);

     void EditStore(Stores Store);
     

    }
}