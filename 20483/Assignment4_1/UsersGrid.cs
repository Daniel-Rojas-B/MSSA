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
    public partial class UsersGrid : Form
    {
        public UsersGrid()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser newUserForm = new AddNewUser();
            newUserForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            peopleGrid.DataSource = null;
            peopleGrid.DataSource = new BindingSource { DataSource = Data.People.Values.ToList() };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the user?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string keyToRemove = peopleGrid.CurrentRow.Cells[0].Value.ToString();


                if (Data.People.ContainsKey(keyToRemove))
                {
                    Data.People.Remove(keyToRemove);
                }

                peopleGrid.DataSource = null;
                peopleGrid.DataSource = new BindingSource { DataSource = Data.People.Values.ToList() };
            }
        }

        private void UsersGrid_Load(object sender, EventArgs e)
        {
            peopleGrid.DataSource = null;
            peopleGrid.DataSource = new BindingSource { DataSource = Data.People.Values.ToList() };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search newSearchForm = new Search(this);
            newSearchForm.ShowDialog();
        }

        public void UpdateUsersGrid(string userKey)
        {
            if (Data.People.ContainsKey(userKey)) 
            {
                var user = Data.People[userKey]; 
                peopleGrid.DataSource = new List<Person> { user }; 
            }
            
        }
    }
}
