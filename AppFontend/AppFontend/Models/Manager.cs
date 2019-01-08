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
        public Dictionary<int, Employee> listTeacher = new Dictionary<int, Employee>();

        // constructor
        public Manager(int id, string name, string phonenumber, string address, string email)
            : base(id, name, phonenumber, address, email) { }

        public override bool Add(int id, Employee c)
        {
            this.listTeacher.Add(id, c);
            return true;
        }

        public override bool Remove(int id)
        {
            this.listTeacher.Remove(id);
            return false;
        }

        // Thêm khóa học mới
        public void addNewCourse(Course c)
        {
            // Add new course API
        }

        // Thêm giáo viên vào Khóa học
        public void addTeacherIntoCourse(int idTeacher, Teacher tc,int idCourse, Course c)
        {
            c.listTeacher.Add(idTeacher, tc);
            // Add new teacher into Course API
        }

        // Test debug
        public override void Display(int depth)
        {
            Trace.WriteLine(this.name);
            //foreach(Employee e in listTeacher)
            //{
            //    e.Display(depth + 2);
            //}
        }
    }
}
