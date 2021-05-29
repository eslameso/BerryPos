using System.Threading.Tasks;
using Pos.Data.Interfaces;

namespace Pos.Data.Intefaces
{
    public interface IUnitOfWork
    {
        IBranchesRepo Branches {get;}
        IJobtitlesRepo JobTitles {get;}
        ICategoriesRepo categories{get;}
        IClientsRepo  clients{get;}
        ISuppliersRepo Suppliers{get;}
        IStoresRepo Stores {get;}
        ICompanyProfileRepo CompanyProfile {get;}
        IProductsRepo Products{get;}
        
        
        bool SaveAsync();
        
    }
}