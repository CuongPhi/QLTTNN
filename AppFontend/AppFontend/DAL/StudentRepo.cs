using AppFontend.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.DAL
{
    public sealed class StudentRepo : IRepos<object>
    {

        /*
         *  only 1 instance will create 
         */
        private static readonly StudentRepo studentIns = new StudentRepo();
        private HttpC<STUDENT> http = new HttpC<STUDENT>();

        private StudentRepo() { }

        public static StudentRepo StudentIns
        {
            get { return studentIns; }
        }

        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAll()
        {
            return await http.FetchDataAsync("http://localhost:3001/student");
        }

        public object GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public object Insert(object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
