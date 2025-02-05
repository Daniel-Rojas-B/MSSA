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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.GPA = double.Parse(txtGPA.Text);
            
            Data.Students.Add(student);
            MessageBox.Show("Student added");
            this.Close();
            StudentsMain studentsMainForm = new StudentsMain();
            studentsMainForm.Show();

        }
    }
}
