using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Inheritancedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.AccountNumber = 224242;
            savingsAccount.HolderName = "Frank S";
            Console.WriteLine($"For account {savingsAccount.AccountNumber} please set the balance:");
            double balance = double.Parse( Console.ReadLine() );
            if (balance >= savingsAccount.MinBalance)
            {
                savingsAccount.Balance = balance;
            }
            Console.WriteLine($"The balance is {savingsAccount.Balance}");

            Console.ReadKey();

            CheckingAccount checkingAccount = new CheckingAccount();
            Console.WriteLine($"min balance for checking is {checkingAccount.MinBalance}");

            Console.ReadKey();
        }
    }
}
