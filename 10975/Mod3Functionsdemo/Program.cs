using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Functionsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            DisplayGreeting(name); // calling the method with a string parameter
            int num1, num2;
            Console.WriteLine("Enter 2 numbers to add: ");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = AddNumbers(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {result}");
            Console.ReadKey();
        }

        static void DisplayGreeting(string nameOfPerson) // list of parameters
        {
            Console.WriteLine("Welcome " + nameOfPerson); // concatenation
            Console.WriteLine($"Hi {nameOfPerson}, How are you?"); // interpolation
        }
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
