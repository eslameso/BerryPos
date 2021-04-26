using System.Threading.Tasks;
using Pos.Data.Interfaces;

namespace Pos.Data.Intefaces
{
    public interface IUnitOfWork
    {
        IBranchesRepo Branches {get;}
        IJobtitlesRepo JobTitles {get;}
        
        bool SaveAsync();
        
    }
}