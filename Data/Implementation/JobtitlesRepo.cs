using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class JobtitlesRepo :IJobtitlesRepo
    {
          private readonly ApplicationDbContext _db;
             public UserManager<ApplicationUsers> _UserManager { get; }

       public JobtitlesRepo(ApplicationDbContext db,UserManager<ApplicationUsers> UserManager)
       {
         _db=db;
         _UserManager=UserManager;
       }

        public async  Task<List<JobTitles>> GetAllJobTitles()
        {
           return await _db.JobTitles.ToListAsync();
        }

         public void DeleteJobTitle(int Id)
        {
            var JobTitle=_db.JobTitles.Find(Id);
            if (JobTitle !=null)
            {
                _db.Remove(JobTitle);
            }
            
        }

      

        public IEnumerable<JobTitles> GetAllJobTitlesSD(string SearchBar)
        {
            var Data= _db.JobTitles.Where(m => m.Code.ToString().Contains(SearchBar) 
            || m.Name.Contains(SearchBar) || m.Notes.Contains(SearchBar));
            
            return Data;
        }

        public bool HasForegnKeyWithUser(int Id)
        {
           var count= _db.JobTitles.Include(m => m.Users).FirstOrDefault(s =>s.Id==Id).Users.Count();
           if (count == 0)
           {
               return false;
           }
           else
           {
               return true;
           }
           
        }

        public bool IsCreateCodeExist(int Code)
        {
            return (! _db.JobTitles.Any(m => m.Code==Code));
        }

        public bool IsCreateNameExist(string Name)
        {
            return (! _db.JobTitles.Any(m => m.Name==Name));
        }

        public void CreateJobTitle(JobTitles JobTitle)
        {
            _db.Add(JobTitle);
        }

        public JobTitles FindJobTitle(int id)
        {
            return _db.JobTitles.Find(id);
        }

        public bool IsEditCodeExist(int Code, int id)
        {
            return (! _db.JobTitles.Any(m=>m.Id != id && m.Code==Code));
        }

        public bool IsEditNameExist(string Name, int id)
        {
            return (! _db.JobTitles.Any(m=>m.Id != id && m.Name==Name));
        }

        public void EditJobTitle(JobTitles JobTitle)
        {
            
            _db.Update(JobTitle);
        }

     

      
    }
}