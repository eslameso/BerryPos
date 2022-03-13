using System.Collections.Generic;
using System.Threading.Tasks;
using Pos.Models;

namespace Pos.Data.Intefaces
{
    public interface IJobtitlesRepo
    {
         Task<List<JobTitles>> GetAllJobTitles();
         
     
     //SD This Mean That This Action Is For Server Side Data Table
     IEnumerable<JobTitles> GetAllJobTitlesSD(string SearchBar);
     void DeleteJobTitle(int Id);
     
     bool HasForegnKeyWithUser(int Id);
     bool IsCreateCodeExist(int Code);
     bool IsCreateNameExist(string Name);

      bool IsEditCodeExist(int Code,int id);
     bool IsEditNameExist(string Name,int id);

     void CreateJobTitle(JobTitles JobTitle);

     JobTitles FindJobTitle(int id);

     void EditJobTitle(JobTitles JobTitle);
    }
}