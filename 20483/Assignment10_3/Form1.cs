using Assignment10_3.Services;
using Assignment10_3.Models;
using System.Xml.Linq;
namespace Assignment10_3
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            carGrid.DataSource = crud.GetCars();
            txtVIN.Enabled = false;
            

        }

        private void btnVIN_Click(object sender, EventArgs e)
        {
            txtVIN.Text = crud.GetVIN();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMake.Text) && !string.IsNullOrEmpty(txtModel.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtYear.Text))
            {

                var newCar = new Car();
                newCar.Vin = txtVIN.Text;
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Year = int.Parse(txtYear.Text);
                newCar.Price = decimal.Parse(txtPrice.Text);
                crud.AddRecord(newCar);
                MessageBox.Show("Record added!");

            }
            btnAdd.Enabled = false;
            carGrid.DataSource = crud.GetCars();


            txtVIN.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVIN.Text;
            var carToUpdate = crud.FindCar(vin);
            carToUpdate.Make = txtMake.Text;
            carToUpdate.Model = txtModel.Text;
            carToUpdate.Year = int.Parse(txtYear.Text);
            carToUpdate.Price = decimal.Parse(txtPrice.Text);

            crud.UpdateRecord(vin, carToUpdate);
            MessageBox.Show("Record updated!");
            carGrid.DataSource = crud.GetCars();
            btnUpdate.Enabled = false;

            txtVIN.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = carGrid.CurrentRow.Cells[0].Value?.ToString();
            var cartoupdate = crud.FindCar(vin);
            txtVIN.Text = cartoupdate.Vin.ToString();
            txtMake.Text = cartoupdate.Make.ToString();
            txtModel.Text = cartoupdate.Model.ToString();
            txtYear.Text = cartoupdate.Year.ToString();
            txtPrice.Text = cartoupdate.Price.ToString();

            txtVIN.Enabled = false;
            btnUpdate.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var vin = carGrid.CurrentRow.Cells[0].Value?.ToString();
            crud.DeleteRecord(vin);
            MessageBox.Show("record deleted");
            carGrid.DataSource = crud.GetCars();
        }
    }
}
