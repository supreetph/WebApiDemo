using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JObCategoryController : ControllerBase
    {
       private readonly IJobCategory _jobCategory;
        public JObCategoryController(IJobCategory jobCategory)
        {
            _jobCategory = jobCategory;
        }
        // GET: api/<JObCategoryController>
        [HttpGet]
        public IEnumerable<JobCategory> Get()
        {
            return _jobCategory.GetJobCategories();
        }

        // GET api/<JObCategoryController>/5
        [HttpGet("{id}")]
        public JobCategory Get(int id)
        {
            return _jobCategory.GetJobCategoryByID(id);
        }

        // POST api/<JObCategoryController>
        [HttpPost]
        public JobCategory Post([FromBody] JobCategory value)
        {
           return _jobCategory.AddJObCategory(value);
        }

        // PUT api/<JObCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JObCategoryController>/5
        [HttpDelete("{id}")]
        public JobCategory Delete(int id)
        {
            return _jobCategory.DeleteJobCategory(id);
        }
    }
}
