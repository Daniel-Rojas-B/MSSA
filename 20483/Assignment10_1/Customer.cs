using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }

        public Customer() { }

        public Customer(int id, string name, float balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
    }
}
