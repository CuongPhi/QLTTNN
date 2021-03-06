﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFontend.DTO;

namespace AppFontend.DAL
{
    public sealed class CourseRepo : IRepos<object>
    {

        /*
         *  only 1 instance will create 
         */
        private static readonly CourseRepo courseIns = new CourseRepo();
        private HttpC<COURSE> http = new HttpC<COURSE>();

        private CourseRepo() { }

        public static CourseRepo CourseIns
        {
            get { return courseIns; }
        }

        //
        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAll()
        {
            return await http.FetchDataAsync("http://localhost:3001/course");

        }

  

        public object Insert(object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(COURSE obj)
        {
            throw new NotImplementedException();
        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }

        object IRepos<object>.GetByID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
