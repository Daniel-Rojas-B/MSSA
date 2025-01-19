using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number(Table to be calculated):");
            int number = Int32.Parse(Console.ReadLine());
            multiplicationTable(number);
        }    
        static void multiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "X" + i + " = " + i * number);
            }
        }

    }
}
