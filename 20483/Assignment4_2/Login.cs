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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "a" && txtPassword.Text == "1")
            {
                this.Hide();
                StudentsMain studentsMainForm = new StudentsMain();
                studentsMainForm.Show();
                MessageBox.Show("Welcome Professor!");
                
            }
            else
            {
                MessageBox.Show("Invalid attemp, please try again");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
