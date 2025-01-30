using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod3EmployeeSystem
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // reading all the values from department enum and putting them in combo box
            comboDept.DataSource = Enum.GetValues(typeof(Department));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEid.Text != string.Empty && txtName.Text != string.Empty)
            {
                var newEmp = new Employee();
                newEmp.EmployeeId = int.Parse(txtEid.Text);
                newEmp.FullName = txtName.Text;
                newEmp.Address = txtAddress.Text;
                newEmp.Salary = double.Parse(txtSalary.Text);
                newEmp.Dept = (Department)(comboDept.SelectedIndex + 1); // 0+1=1
                Data.Employees.Add(newEmp);
                MessageBox.Show("Record added!");
            }
        }

        private void txtEid_Validating(object sender, CancelEventArgs e)
        {
            if (txtEid.TextLength != 0) // user entered some data and i need to validate it
            {
                int val;
                if (int.TryParse(txtEid.Text, out val))
                {
                    MessageBox.Show("Please enter digits only");
                    e.Cancel = true; // focus on same textbook
                    txtEid.Clear();
                }
                else if (int.Parse(txtEid.Text) <= 0)
                {
                    MessageBox.Show("Id has to be greater than 0");
                    e.Cancel = true;
                    txtEid.Clear();
                }
            }
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (txtSalary.TextLength != 0)
            {
                int val;
                if(!int.TryParse(txtSalary.Text, out val))
                {
                    MessageBox.Show("Please enter numbers!");
                    e.Cancel = true;
                    txtSalary.Clear();
                }
            }
        }
    }
}
