using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Interfaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class SuppliersRepo : ISuppliersRepo
    {
       private readonly ApplicationDbContext _db;
        public UserManager<ApplicationUsers> _UserManager { get; }

       public SuppliersRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public void DeleteSupplier(int Id)
        {
            var Supplier=_db.Suppliers.Find(Id);
            if (Supplier !=null)
            {
                _db.Remove(Supplier);
            }
            
        }

        public async Task<List<Suppliers>> GetAllSuppliers()
        {
           return await _db.Suppliers.ToListAsync();
        }

        public IEnumerable<Suppliers> GetAllSuppliersSD(string SearchBar)
        {
            var Data= _db.Suppliers.Where(m => m.Code.ToString().Contains(SearchBar) 
            || m.Name.Contains(SearchBar)
            || m.MobileNumber.Contains(SearchBar) 
            || m.Email.Contains(SearchBar));
            return Data;
        }


        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.Suppliers.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.Suppliers.Any(m => m.Name==Name));
        }

        public void CreateSupplier(Suppliers Supplier)
        {
            _db.Add(Supplier);
        }

        public Suppliers FindSupplier(int id)
        {
            return _db.Suppliers.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.Suppliers.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.Suppliers.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditSupplier(Suppliers Supplier)
        {
            
            _db.Update(Supplier);
        }

        public bool IsEmailInUse(string Email)
        {
            bool Result = _db.Suppliers.Where(c => c.Email ==Email).Any();
            return Result;
        }

        public bool HasForegnKeyWithPurchaseInvoice(int id)
        {
            var Count = _db.Suppliers.Include(m => m.PurchaseInvoices).FirstOrDefault(m=>m.Id==id).PurchaseInvoices.Count();
             if (Count == 0)
             {
                 return false;
             }
             else{
                 return true;
             }
        }

        public bool IsEmailInUseEdit(string Email, int Id)
        {
           bool Result = _db.Suppliers.Where(c => c.Email ==Email && c.Id != Id).Any();
            return Result;
        }
    }
}