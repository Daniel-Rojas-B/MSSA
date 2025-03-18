using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment10_1
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        string jsonPath = @"C:\Users\danie\Documents\MSSA\20483\Assignment10_1\assignment10json.txt";
        string xmlPath = @"C:\Users\danie\Documents\MSSA\20483\Assignment10_1\assignment10xml.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtId.Text, out int id) && float.TryParse(txtBalance.Text, out float balance))
            {
                customers.Add(new Customer(id, txtName.Text, balance));
                MessageBox.Show("Customer added successfully!");
            }

        }

        private void btnJSONser_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonPath))
            {
                File.Delete(jsonPath);
            }

            using (FileStream jsonStream = new FileStream(jsonPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                JsonSerializer.Serialize(jsonStream, customers);
            }

            MessageBox.Show("Customers serialized to JSON");
        }

        private void btnJSONdes_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(jsonPath))
            {
                using (FileStream jsonStream = new FileStream(jsonPath, FileMode.Open, FileAccess.Read))
                {
                    customers = JsonSerializer.Deserialize<List<Customer>>(jsonStream);
                }

                MessageBox.Show("Customers deserialized from JSON");
            }
        }

        private void btnXMLser_Click(object sender, EventArgs e)
        {

            if (File.Exists(xmlPath))
            {
                File.Delete(xmlPath);
            }

            FileStream xmlStream = new FileStream(xmlPath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            xmlSerializer.Serialize(xmlStream, customers);
            xmlStream.Close();

            MessageBox.Show("Customers serialized to XML");
        }

        private void btnXMLdes_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(xmlPath))
            {
                FileStream xmlStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
                customers = (List<Customer>)xmlSerializer.Deserialize(xmlStream);
                xmlStream.Close();
                MessageBox.Show("Customers deserialized from XML");
            }
        }
    }
}
