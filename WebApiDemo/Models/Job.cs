﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiDemo.Models
{
    public partial class Job
    {
        public int Id { get; set; }
        public string OpportunityId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int? JobCategoryId { get; set; }
        public int? JobTypeId { get; set; }
        public string ExperienceRequired { get; set; }
        public DateTime? ClosingDate { get; set; }

        public virtual JobCategory JobCategory { get; set; }
        public virtual JobType JobType { get; set; }
    }
}
