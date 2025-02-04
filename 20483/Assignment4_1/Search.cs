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
    public partial class Search : Form
    {
        private UsersGrid usersGridForm;
        public Search(UsersGrid userGridForm)
        {
            InitializeComponent();
            this.usersGridForm = userGridForm ?? throw new ArgumentNullException(nameof(userGridForm));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = txtSearch.Text;
            if (Data.People.ContainsKey(searchKey))
                {
                    MessageBox.Show("User found");                    
                    usersGridForm.UpdateUsersGrid(searchKey);

            }
                else
                {
                    MessageBox.Show("User not found");

                }
            this.Close();

        }
    }
}
