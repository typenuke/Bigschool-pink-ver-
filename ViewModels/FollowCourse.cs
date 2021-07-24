using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
    public class FollowCourse
    {
        public IEnumerable<Course> Courses { get; set; }
        public bool ShowAction { get; set; }
    }
}