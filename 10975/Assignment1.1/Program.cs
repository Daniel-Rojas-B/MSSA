using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Assignment1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string address;
            int result;

            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "! How old are you?");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is your address?");
            address = Console.ReadLine();
            Console.WriteLine("--- User Info: ---\n" + "Name: " + name + "\n" + "Age: " + age + "\n" + "Address: " + address);

            int num1, num2;

            Console.WriteLine("Type the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("The sum of both numbers is:" + result);

            float divResult;
            float remainder;

            divResult = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine("The result of dividing num1 by num2 is: " + divResult);
            Console.WriteLine("The remainder is: " + remainder);

            Console.ReadKey();
        }
    }
}
