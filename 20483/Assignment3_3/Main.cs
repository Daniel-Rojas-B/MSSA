using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add AddForm = new Add();
            AddForm.ShowDialog();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            studentGrid.DataSource = null;
            studentGrid.DataSource = Data.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the student?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(studentGrid.CurrentRow.Index);
                studentGrid.DataSource = null;
                studentGrid.DataSource = Data.Students;
            }
        }
    }
}
