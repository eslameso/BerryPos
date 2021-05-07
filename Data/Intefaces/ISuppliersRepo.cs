using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface ISuppliersRepo
    {
     Task<List<Suppliers>> GetAllSuppliers();
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<Suppliers> GetAllSuppliersSD(string SearchBar);
     void DeleteSupplier(int Id);
      bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);
      bool IsEmailInUse(string Email);

      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateSupplier(Suppliers Supplier);

     Suppliers FindSupplier(int id);

     void EditSupplier(Suppliers Supplier);

     bool HasForegnKeyWithPurchaseInvoice(int id);
     

    }
}