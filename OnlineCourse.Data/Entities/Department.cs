﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Data
{
    public class Department 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
