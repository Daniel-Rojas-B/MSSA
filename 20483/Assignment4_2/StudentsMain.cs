using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StudentsGrid.DataSource = null;
            StudentsGrid.DataSource = Data.Students;
        }

        private void StudentsMain_Load(object sender, EventArgs e)
        {
            StudentsGrid.DataSource = null;
            StudentsGrid.DataSource = Data.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the student?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(StudentsGrid.CurrentRow.Index);
                StudentsGrid.DataSource = null;
                StudentsGrid.DataSource = Data.Students;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Data.Students.Sort(new StudentGPAComparer());
            Student highestGPA = Data.Students.Last();
            string filePath = "C:\\Users\\danie\\Documents\\MSSA\\20483\\Assignment4_2\\HighestGPAinfo.txt";            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Student with the Highest GPA:");
                writer.WriteLine($"Id: {highestGPA.Id}");
                writer.WriteLine($"Name: {highestGPA.Name}");
                writer.WriteLine($"GPA: {highestGPA.GPA}");                
            }
            MessageBox.Show($"The student with the highest GPA has been saved");
        }
    }
}
