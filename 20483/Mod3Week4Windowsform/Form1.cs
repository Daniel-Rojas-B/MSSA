namespace Mod3Week4Windowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.LowBalance += BankAccount_LowBalance;
            bankAccount.AccountNumber=int.Parse(txtAccount.Text);
            bankAccount.AccountBalance = double.Parse(txtBalance.Text);
        }

        private void BankAccount_LowBalance(double bal)
        {
            MessageBox.Show($"Balance of the {bal} is too low to open an account, please enter more than 200");
        }
    }
}
