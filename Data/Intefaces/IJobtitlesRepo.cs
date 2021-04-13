using System.Collections.Generic;
using Pos.Models;

namespace Pos.Data.Intefaces
{
    public interface IJobtitlesRepo
    {
         List<JobTitles> GetAllJobTitles();
    }
}