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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var person = new Person();

            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.PhoneNumber = int.Parse(txtPhoneNumber.Text);
            person.WorkNumber = int.Parse(txtWorkNumber.Text);
            person.Address = txtAddress.Text;
            
            Data.People.Add(person.FirstName, person);
            

            MessageBox.Show("User added");
                       

            this.Close();

            
        }
    }
}
