using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CoffeeForm coffeeForm = new CoffeeForm();
            coffeeForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the coffee order?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.coffees.RemoveAt(coffeeOrdersGrid.CurrentRow.Index);
                coffeeOrdersGrid.DataSource = null;
                coffeeOrdersGrid.DataSource = Data.coffees;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            coffeeOrdersGrid.DataSource = null;
            coffeeOrdersGrid.DataSource = Data.coffees;
        }
    }
}
