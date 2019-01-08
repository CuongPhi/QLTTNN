using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFontend.DTO;

namespace AppFontend.DAL
{
    public sealed class CourseRepo : IRepos<COURSE>
    {
        private static readonly CourseRepo courseIns = new CourseRepo(); // only 1 instance will create

        public CourseRepo() { }

        public static CourseRepo CourseIns
        {
            get { return courseIns; }
        }
        public void Delete(COURSE obj)
        {
            throw new NotImplementedException();
        }

        public List<COURSE> GetAll()
        {
            COURSE c = new COURSE() { id = 5, nameCourse = "KTPM", priceCourse = 1050, timeEnd = new DateTime(), timeStart = new DateTime() };
            COURSE c1 = new COURSE() { id = 6, nameCourse = "MMHPM", priceCourse = 1050, timeEnd = new DateTime(), timeStart = new DateTime() };

            List<COURSE> l = new List<COURSE>();
            l.Add(c);
            l.Add(c1);
            return l;

        }

        public COURSE GetByID(string id)
        {
            throw new NotImplementedException();

        }

        public COURSE Insert(COURSE obj)
        {
            throw new NotImplementedException();
        }

        public void Update(COURSE obj)
        {
            throw new NotImplementedException();
        }
    }
}
