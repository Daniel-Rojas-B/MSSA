using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Mod6Serializationdemo
{
    public partial class Form1 : Form
    {
        Student student;
        string jsonpath = @"C:\Users\danie\Documents\MSSA\20483\Mod6Serializationdemo\pecad16json.txt";
        string xmlpath = @"C:\Users\danie\Documents\MSSA\20483\Mod6Serializationdemo\pecad16xml.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Address = txtAddress.Text;
            student.GPA = float.Parse(txtGPA.Text);
            MessageBox.Show("Student created!");
            //File.WriteAllText("c:\\dummyTxt", student.Name);
            //File.WriteAllText("c:\\dummyTxt", student.Address);
        }
        private void btnJSONser_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonpath))
            {
                File.Delete(jsonpath);
            }
            FileStream jsonstream = new FileStream(jsonpath, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonstream, student);
            jsonstream.Close();
            MessageBox.Show("object is serialized");
        }
        
        private void btnJSONdes_Click(object sender, EventArgs e)
        {
            FileStream jsonstream = new FileStream(jsonpath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<Student>(jsonstream);
            MessageBox.Show($"Student name: {obj.Name}, Student GPA: {obj.GPA}");
            jsonstream.Close();
        }
        private void btnXMLser_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }
            FileStream xmlstream = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(xmlstream, student);
            xmlstream.Close();
            MessageBox.Show("student is serialized");
        }

        private void btnXMLdes_Click(object sender, EventArgs e)
        {
            FileStream xmlstream = new FileStream(xmlpath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            var obj = (Student)xmlSerializer.Deserialize(xmlstream);
            MessageBox.Show($"Student name: {obj.Name}, Student id: {obj.Id} Student GPA: {obj.GPA}");
            xmlstream.Close();
        }

        
    }
}
