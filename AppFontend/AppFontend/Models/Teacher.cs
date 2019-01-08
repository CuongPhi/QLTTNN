using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.Models
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class Teacher : Employee
    {
        // Danh sách các khóa học của giáo viên
        public List<Course> listCourse = new List<Course>();

        // constructor
        public Teacher(int id, string name, string phonenumber, string address, string email)
            : base(id, name, phonenumber, address, email) { }

        public void AddCourse(Course c)
        {
            listCourse.Add(c);
        }

        public void RemoveCourse(Course c)
        {
            listCourse.Remove(c);
        }

        public override bool Add(int id, Employee c)
        {
            return false;
        }

        public override bool Remove(int id)
        {
            return false;
        }

        // Test debug
        public override void Display(int depth)
        {
            Trace.WriteLine(this.name);
        }
    }
}
