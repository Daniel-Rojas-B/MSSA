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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != string.Empty && txtLastname.Text != string.Empty)
            {
                var std = new Student();
                std.StudentId = int.Parse(txtSid.Text);
                std.FirstName = txtFirstname.Text;
                std.LastName = txtLastname.Text;
                std.Address = txtAddress.Text;
                std.MonthAdm = (MonthAdm)(comboMonth.SelectedIndex);
                std.Grade = char.Parse(txtGrade.Text);
                Data.Students.Add(std);
                MessageBox.Show("Student registered");
                this.Close();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            comboMonth.DataSource = Enum.GetValues(typeof(MonthAdm));
        }
    }
}
