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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            empGrid.DataSource = Data.Employees;
            empGrid.Columns[3].DisplayIndex = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Employees.RemoveAt(empGrid.CurrentRow.Index);
                empGrid.DataSource = null;
                empGrid.DataSource = Data.Employees;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            empGrid.DataSource = null;
            empGrid.DataSource = Data.Employees;
        }
    }
}
