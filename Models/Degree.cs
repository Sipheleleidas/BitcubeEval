using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace j_stack.net_Project.Models
{
    public class Degree
    {
       
        public int DegreeId { get; set; }
        public string DegreeName { get; set; }
        public int Duration { get; set; }

        List<Course> Courses = new List<Course>();
    }
}