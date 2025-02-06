using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_1_2
{

    public partial class Calculator : Form
    {

        private readonly ICalculator calculator;
        private double currentValue = 0;
        private string currentOperation = "";
        private bool isNewEntry = true;

        public Calculator()
        {
            InitializeComponent();
            calculator = new Math();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (isNewEntry)
            {
                txtResult.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            currentValue = double.Parse(txtResult.Text);
            currentOperation = btn.Text;
            isNewEntry = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double newValue = double.Parse(txtResult.Text);
            double result = 0;

            try
            {
                switch (currentOperation)
                {
                    case "+": result = calculator.Add(currentValue, newValue); break;
                    case "-": result = calculator.Subtract(currentValue, newValue); break;
                    case "*": result = calculator.Multiply(currentValue, newValue); break;
                    case "/": result = calculator.Divide(currentValue, newValue); break;                    
                }
                txtResult.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            isNewEntry = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isNewEntry = true;
        }
        
    }
}

