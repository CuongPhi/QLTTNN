using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFontend.Models
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class Employee
    {
        protected int id;
        protected string name;
        protected string phoneNumber;
        protected string address;
        protected string email;

        // Contructor
        public Employee(int id, string name, string phonenumber, string address, string email)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phonenumber;
            this.address = address;
            this.email = email;
        }

        public abstract bool Add(int id, Employee c);
 
        public abstract bool Remove(int id);

        public abstract void Display(int depth);
    }
}
