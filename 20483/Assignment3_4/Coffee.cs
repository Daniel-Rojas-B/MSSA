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
    public partial class CoffeeForm : Form
    {
        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            comboType.DataSource = Enum.GetValues(typeof(Type));
            comboSize.DataSource = Enum.GetValues(typeof(CoffeeSize));
            comboStrength.DataSource = Enum.GetValues(typeof(Strength));
            comboRoast.DataSource = Enum.GetValues(typeof(Roast));
            comboMilk.DataSource = Enum.GetValues(typeof(Milk));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var coffeeOrder = new Coffee();

            coffeeOrder.Type = (CoffeeType)(comboType.SelectedIndex);
            coffeeOrder.Size = (CoffeeSize)(comboType.SelectedIndex);
            coffeeOrder.Strength = (Strength)(comboType.SelectedIndex);
            coffeeOrder.Roast = (Roast)(comboType.SelectedIndex);
            coffeeOrder.Milk = (Milk)(comboType.SelectedIndex);

            Data.coffees.Add(coffeeOrder);

            MessageBox.Show("Coffee Order Created");
            this.Close();
        }
    }
}
