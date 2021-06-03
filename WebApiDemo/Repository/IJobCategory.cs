using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Repository
{
  public  interface IJobCategory
    {
        IEnumerable<JobCategory> GetJobCategories();
        JobCategory GetJobCategoryByID(int id);
        JobCategory AddJObCategory(JobCategory employee);
        JobCategory UpdateJoCategory(JobCategory employee);
        JobCategory DeleteJobCategory(int id);
    }
}
