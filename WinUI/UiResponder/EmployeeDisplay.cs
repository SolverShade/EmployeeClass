using EmployeeLogic;
using EmployeeLogic.FileReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.UiResponder
{
    public class EmployeeDisplay
    {
        private ListBox _employeeListBox { get; set; }
        private StatusDisplay _statusDisplay { get; set; }
        private EmployeeFetcher _employeeFetcher { get; set; } 
        public EmployeeDisplay(ListBox employeeListBox, StatusDisplay errorDisplay, EmployeeFetcher employeeFetcher)
        {
            _employeeListBox = employeeListBox;
            _statusDisplay = errorDisplay;
            _employeeFetcher = employeeFetcher; 
        }

        public void DisplayOperation()
        {
            List<Employee> employees = _employeeFetcher.FetchEmployees();
            CheckAndDisplayVadility(employees);
            DisplayEmployees(employees);
        }

        private bool CheckAndDisplayVadility(List<Employee> employees)
        {
            if(employees == null)
            {
                _statusDisplay.DisplayMessage("employee file invalid or not present");
                return false;
            }
            else
            {
                _statusDisplay.DisplayMessage("Success!");
                return true;
            }
        }

        private void DisplayEmployees(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                _employeeListBox.Items.Add(employee.Name);
                _employeeListBox.Items.Add(employee.ID.ToString());
                _employeeListBox.Items.Add(employee.Department);
                _employeeListBox.Items.Add(employee.Postion);
                _employeeListBox.Items.Add("");
            }
        }
    }
}
