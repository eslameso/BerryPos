using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class ClientsRepo : IClientsRepo
    {
       private readonly ApplicationDbContext _db;
        public UserManager<ApplicationUsers> _UserManager { get; }

       public ClientsRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public void DeleteClient(int Id)
        {
            var Client=_db.Clients.Find(Id);
            if (Client !=null)
            {
                _db.Remove(Client);
            }
            
        }

        public async Task<List<Clients>> GetAllClients()
        {
           return await _db.Clients.ToListAsync();
        }

        public IEnumerable<Clients> GetAllClientsSD(string SearchBar)
        {
            var Data= _db.Clients.Where(m => m.Code.ToString().Contains(SearchBar) 
            || m.Name.Contains(SearchBar)
            || m.MobileNumber.Contains(SearchBar) 
            || m.Email.Contains(SearchBar));
            return Data;
        }


        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.Clients.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.Clients.Any(m => m.Name==Name));
        }

        public void CreateClient(Clients Client)
        {
            _db.Add(Client);
        }

        public Clients FindClient(int id)
        {
            return _db.Clients.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.Clients.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.Clients.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditClient(Clients Client)
        {
            
            _db.Update(Client);
        }

        public bool IsEmailInUse(string Email)
        {
            bool Result = _db.Clients.Where(c => c.Email ==Email).Any();
            return Result;
        }
    }
}