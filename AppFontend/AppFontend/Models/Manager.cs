using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.Models
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Manager : Employee
    {
        public List<Employee> listTeacher = new List<Employee>();

        // constructor
        public Manager(int id, string name, string phonenumber, string address, string email)
            : base(id, name, phonenumber, address, email) { }

        public override bool Add(Employee c)
        {
            this.listTeacher.Add(c);
            return true;
        }

        public override bool Remove(Employee c)
        {
            this.listTeacher.Remove(c);
            return false;
        }

        // Thêm khóa học mới
        public void addNewCourse(Course c)
        {
            // Add new course API
        }

        // Thêm giáo viên vào Khóa học
        public void addTeacherIntoCourse(Teacher tc, Course c)
        {
            c.listTeacher.Add(tc);
            // Add new teacher into Course API
        }

        // Test debug
        public override void Display(int depth)
        {
            Trace.WriteLine(this.name);
            foreach(Employee e in listTeacher)
            {
                e.Display(depth + 2);
            }
        }
    }
}
