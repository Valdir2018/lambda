using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities
{
    class Employees
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary{ get; set; }

        // Constructor
        public Employees(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }




    }
}
