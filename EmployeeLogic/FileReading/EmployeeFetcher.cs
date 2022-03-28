using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EmployeeLogic.FileReading
{
    public class EmployeeFetcher
    {
        private string _employeeBatchPath; 
        public EmployeeFetcher(string employeeBatchPath)
        {
            _employeeBatchPath = employeeBatchPath;
        }

        public List<Employee> FetchEmployees()
        {
            try
            {
                return FetchEmployeeOperation();                
            }
            catch
            {
                return null;
            }
        }

        private List<Employee> FetchEmployeeOperation()
        {
            List<Employee> employees = new List<Employee>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(_employeeBatchPath);

            foreach (XmlNode node in xDoc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int id = int.Parse(node.Attributes[1].Value);
                string department = node.Attributes[2].Value;
                string position = node.Attributes[3].Value;
                employees.Add(new Employee(name, id, department, position));
            }

            return employees;
        }
    }
}
