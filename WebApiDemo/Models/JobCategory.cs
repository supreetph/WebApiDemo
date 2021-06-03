using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiDemo.Models
{
    public partial class JobCategory
    {
        public JobCategory()
        {
            Jobs = new HashSet<Job>();
        }

        public int JobCategoryId { get; set; }
        public string JobCategoryDescription { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
