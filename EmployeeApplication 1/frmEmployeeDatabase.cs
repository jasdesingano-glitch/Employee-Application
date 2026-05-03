using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication_1
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Focus();

            dgvEmployees.Columns.Add("EmployeeID", "Employee ID");
            dgvEmployees.Columns.Add("FirstName", "First Name");
            dgvEmployees.Columns.Add("LastName", "Last Name");
            dgvEmployees.Columns.Add("Position", "Position");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            EmployeeInfo emp = new EmployeeInfo(
                txtEmployeeID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtPosition.Text
            );

            dgvEmployees.Rows.Add(
                emp.employeeID,
                emp.firstName,
                emp.lastName,
                emp.position
            );

            ClearInputs();
        }

        private void ClearInputs()
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
            txtEmployeeID.Focus();
        }
    }
}

