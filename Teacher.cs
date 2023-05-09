using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Teacher() 
        {

        }

        public Teacher(int id, string name, string gender, int salary)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;    
        }

       
    }
}
