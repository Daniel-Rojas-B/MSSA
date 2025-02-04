using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_2
{
    public partial class StudentsMain : Form
    {
        public StudentsMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            this.Hide();
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.Show();            
        }
    }
}
