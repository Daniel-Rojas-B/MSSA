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

            Console.WriteLine("Input number of terms");
            int terms = Int32.Parse(Console.ReadLine());
            oddNaturalNumbers(terms);
        }    
        static void multiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "X" + i + " = " + i * number);
            }
        }
        static void oddNaturalNumbers(int terms)
        {
            int sum = 0;
            int numberOdd = 0;
            Console.WriteLine("The odd numbers are:");
            for (int i = 1; i <= terms; i++)
            {

                Console.Write(numberOdd + 1 + " ");
                sum += numberOdd + 1;
                numberOdd = numberOdd + 2;
                
            }
            Console.WriteLine();
            Console.WriteLine("The sum of odd numbers are:" + sum);
        }

    }
}
