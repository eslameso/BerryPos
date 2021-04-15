using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Intefaces
{
    public interface IJobtitlesRepo
    {
         Task<List<JobTitles>> GetAllJobTitles();
    }
}