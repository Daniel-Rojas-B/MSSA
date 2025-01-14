using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables and data types demo");

            // data type and variable name
            int i; //32 bit signed
            char c='n'; // initializing
            float rateOfInterest = 2.4f;
            string name;
            string address;
            float age;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine(name + ", Where do you live?:");
            address=Console.ReadLine();

            Console.WriteLine("Oh, you live in " + address + ". How old are you?");
            age = Convert.ToSingle(Console.ReadLine());

            int num1, num2;
            Console.WriteLine("Enter num1 and num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("The sum is: " + result);
            float divResult = num1 / num2;
            float remainder = num1 % num2;
            Console.WriteLine(divResult);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
