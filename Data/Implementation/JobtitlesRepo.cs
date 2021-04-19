using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos.Data.Implementation
{
    public class JobtitlesRepo :IJobtitlesRepo
    {
          private readonly ApplicationDbContext _db;

       public JobtitlesRepo(ApplicationDbContext db)
       {
         _db=db;
       }

        public async  Task<List<JobTitles>> GetAllJobTitles()
        {
           return await _db.JobTitles.ToListAsync();
        }
    }
}