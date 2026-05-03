using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeApplication_1
{
    public partial class EmployeeInfo : Form
    {
        public string employeeID;
        public string firstName;
        public string lastName;
        public string position;
        public string city;
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        public EmployeeInfo(string employeeID, string firstName, string lastName, string position)
        {
            InitializeComponent();

            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }

}
