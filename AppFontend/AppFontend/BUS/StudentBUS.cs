using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFontend.DTO;
using AppFontend.DAL;

namespace AppFontend.BUS
{
    public sealed class StudentBUS
    {
        private StudentRepo reps;
        public StudentBUS()
        {
            reps = StudentRepo.StudentIns;
        }
        public async Task<object> get_Students()
        {
            return await reps.GetAll(); // get all students
        }
    }
}
