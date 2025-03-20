using Mod7CodeFirstDemo.Models;
using Mod7CodeFirstDemo.Services;

namespace Mod7CodeFirstDemo
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            empGrid.DataSource = crud.GetEmployees();
            empGrid.Columns[4].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            foreach (var d in crud.GetDepartments())
            {
                comboDept.Items.Add(d.DepartmentName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEid.Text = (crud.GetMaxId() + 1).ToString();
            txtEid.ReadOnly = true;
            txtName.Clear();
            txtSalary.Clear();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEid.Text) && !string.IsNullOrEmpty(txtName.Text))
            {
                if (comboDept.SelectedIndex != -1)
                {
                    var newEmp = new Employee();
                    newEmp.EmpId = int.Parse(txtEid.Text);
                    newEmp.Name = txtName.Text;
                    newEmp.Salary = double.Parse(txtSalary.Text);
                    newEmp.DepartmentId = comboDept.SelectedIndex + 1;
                    crud.AddRecord(newEmp);
                    MessageBox.Show("Record added!");
                }
            }
            btnSubmit.Enabled = false;
            empGrid.DataSource = crud.GetEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            crud.DeleteRecord((int)id);
            MessageBox.Show("record deleted");
            empGrid.DataSource = crud.GetEmployees();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            var emptoupdate = crud.FindEmployee((int)id);
            txtEid.Text = emptoupdate.EmpId.ToString();
            txtEid.ReadOnly = true;
            txtName.Text = emptoupdate.Name;
            txtSalary.Text = emptoupdate.Salary.ToString();
            comboDept.SelectedIndex = emptoupdate.DepartmentId - 1;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtEid.Text);
            var empToUpdate = crud.FindEmployee((int)id);
            empToUpdate.Name = txtName.Text;
            empToUpdate.Salary = double.Parse(txtSalary.Text);
            empToUpdate.DepartmentId = comboDept.SelectedIndex + 1;
            crud.UpdateRecord(id, empToUpdate);
            MessageBox.Show("Record updated!");
            empGrid.DataSource = crud.GetEmployees();
            btnUpdate.Enabled = false;
            //Clear();

        }
    }
}
