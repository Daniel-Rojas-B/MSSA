using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser newUserForm = new AddNewUser();
            newUserForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            UsersGrid usersGridForm = new UsersGrid();
            usersGridForm.ShowDialog();
        }
    }
}
