using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depot
{
    public class Employee
    {
        public int id { get; set; }
        public string password{get; set;}

        public int pm { get; set; }
        public Employee(int id,string pwd,int pm)
        {
            this.id = id;
            this.password = pwd;
            this.pm = pm;
        }
    }
}
