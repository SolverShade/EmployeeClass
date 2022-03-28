using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLogic
{
    public class Employee
    {
        public string Name;
        public int ID;
        public string Department;
        public string Postion; 

        public Employee(string name, int id, string department, string postion)
        {
            Name = name;
            ID = id;
            Department = department;
            Postion = postion;
        }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
            Department = "";
            Postion = "";
        }
        public Employee()
        {
            Name = "";
            ID = 0;
            Department = "";
            Postion = "";
        }



    }
}
