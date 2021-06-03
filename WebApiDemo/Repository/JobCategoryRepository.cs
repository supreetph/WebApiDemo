using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Repository
{
    public class JobCategoryRepository : IJobCategory
    {
        private readonly  RecruitmentContext _dbContext;
        public JobCategoryRepository(RecruitmentContext recruitmentContext)
        {
            _dbContext = recruitmentContext;
        }
        public JobCategory AddJObCategory(JobCategory employee)
        {
            if (employee != null)
            {
                _dbContext.JobCategories.Add(employee);
                _dbContext.SaveChanges();
                return employee;
            }
            return null;
        }

        public JobCategory DeleteJobCategory(int id)
        {
            var jobCat = _dbContext.JobCategories.FirstOrDefault(a => a.JobCategoryId == id);
            _dbContext.Entry(jobCat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _dbContext.SaveChanges();
            return jobCat;
        }

        public IEnumerable<JobCategory> GetJobCategories()
        {
            var categories = _dbContext.JobCategories.ToList();
            return categories;
        }

        public JobCategory GetJobCategoryByID(int id)
        {
            var categories = _dbContext.JobCategories.Where(a=>a.JobCategoryId==id).Select(a=>a).ToList();
             return categories.FirstOrDefault();
        }

        public JobCategory UpdateJoCategory(JobCategory employee)
        {
            throw new NotImplementedException();
        }
    }
}
