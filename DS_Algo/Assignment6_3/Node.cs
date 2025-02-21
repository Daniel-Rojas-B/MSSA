using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_3
{
    internal class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        //public int data;
        public Customer next;

        public Customer(int  customerId, string customerName, Customer next)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.next = next;
        }
        public class Q
        {
            Customer front;
            Customer rear;
            int size;

            public Q()
            {
                this.front = null;
                this.rear = null;
                this.size = 0;
            }
            public bool IsEmpty()
            {
                return size == 0;
            }
            public void Enqueue(int customerId, string customerName)
            {
                Customer newCustomer = new Customer(customerId, customerName, null);

                if (IsEmpty())
                {
                    front = newCustomer;
                }
                else
                {
                    rear.next = newCustomer;
                }
                rear = newCustomer;
                size++;
            }
            public int? Dequeue()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Q is empty");
                    return null;
                }
                int customerId = front.customerId;
                string customerName = front.customerName;
                front = front.next;
                size--;
                if (IsEmpty())
                {
                    rear = null;
                }
                return customerId;
            }
            public void Display()
            {
                Customer temp = front;
                while (temp != null)
                {
                    Console.WriteLine($"Customer Id: {temp.customerId}, Customer Name:{temp.customerName}");
                    temp = temp.next;
                }
                Console.WriteLine();
            }

        }
    }
}
