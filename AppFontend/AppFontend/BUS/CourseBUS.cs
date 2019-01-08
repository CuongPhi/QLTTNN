using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFontend.DTO;
using AppFontend.DAL;

namespace AppFontend.BUS
{
    public  class CourseBUS
    {
        static IRepos<COURSE> reps;
        static CourseBUS()
        {
            reps = new CourseRepo();
        }
        public static List<string> Courses_Name()
        {
            return reps.GetAll().Select(c => c.nameCourse).ToList(); // get all list course name from list course 
        }

    }
}
