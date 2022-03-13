

using Pos.Models;

namespace Pos.Data.Intefaces
{
    public interface ICompanyProfileRepo
    {
        CompanyProfile GetComapnyData();
        void EditCompanyProfile(CompanyProfile companyProfile);
        void CreateCompanyProfile(CompanyProfile companyProfile);
        CompanyProfile FindCompanyProfile(int id);
    }
}