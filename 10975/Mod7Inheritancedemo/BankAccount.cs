using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Inheritancedemo
{
    internal class BankAccount //internal is available in the same assembly
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        protected double minBalance; // it is inherited in derived class, but hidden from client code

        public double MinBalance { get { return this.minBalance; } }

        //public void setBalance()
        //{ 
        //}

    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            this.minBalance = 300;
        }
    }
    class CheckingAccount : BankAccount
    {
        public CheckingAccount()
        {
            this.minBalance = 50;
        }
    }
}
