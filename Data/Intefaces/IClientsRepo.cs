using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Interfaces
{
    public interface IClientsRepo
    {
     Task<List<Clients>> GetAllClients();
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<Clients> GetAllClientsSD(string SearchBar);
     void DeleteClient(int Id);
      bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);
      bool IsEmailInUse(string Email);
      bool IsEmailInUseEdit (string Email,int Id);
      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateClient(Clients Client);

     Clients FindClient(int id);

     void EditClient(Clients Client);

     bool HasForegnKeyWithSalesInvoice(int id);
     

    }
}