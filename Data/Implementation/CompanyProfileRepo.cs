using System.Linq;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class CompanyProfileRepo : ICompanyProfileRepo
    {
        public ApplicationDbContext _db ;
        public CompanyProfileRepo(ApplicationDbContext db)
        {
            _db = db;

        }

        public void CreateCompanyProfile(CompanyProfile companyProfile)
        {
            _db.CompanyProfile.Add(companyProfile);
        }

        public void EditCompanyProfile(CompanyProfile companyProfile)
        {
            _db.Update(companyProfile);
            
        }

        public CompanyProfile FindCompanyProfile(int id)
        {
            return _db.CompanyProfile.Find(id);
        }

        public CompanyProfile GetComapnyData()
        {
            return _db.CompanyProfile.Take(1).FirstOrDefault();
        }
    }
}