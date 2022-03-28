using EmployeeLogic.FileReading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.UiResponder;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeFetcher employeeFechter = new EmployeeFetcher(@".\Database\Employees.xml");
            StatusDisplay statusDisplay = new StatusDisplay(StatusLabel);
            EmployeeDisplay employeeDisplay = new EmployeeDisplay(EmployeeListBox, statusDisplay, employeeFechter);

            employeeDisplay.DisplayOperation();
        }
    }
}
