using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.Models
{
    class Course
    {
        protected string nameCourse;
        protected int priceCourse;
        protected DateTime timeStart;
        protected DateTime timeEnd;

        // Danh sách giáo viên của khóa học
        public List<Teacher> listTeacher = new List<Teacher>();
        // List sinh viên của khóa học
        public List<Student> listStudent = new List<Student>();
    }
}
