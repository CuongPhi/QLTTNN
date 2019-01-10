using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFontend.DTO;
using AppFontend.DAL;

namespace AppFontend.BUS
{
    public sealed  class CourseBUS
    {
        private CourseRepo reps;
        public CourseBUS()
        {
            reps = CourseRepo.CourseIns;
        }
        public async Task<object> get_Course()
        {
            return await reps.GetAll(); // get all list course name from list course 
        }
    }
}
