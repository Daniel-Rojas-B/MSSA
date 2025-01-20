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
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine("Input the number(Table to be calculated):");
            int number = Int32.Parse(Console.ReadLine());
            multiplicationTable(number);

            Console.WriteLine(" ---- Problem 2 ---- ");
            Console.WriteLine("Input number of terms");
            int terms = Int32.Parse(Console.ReadLine());
            oddNaturalNumbers(terms);

            Console.WriteLine(" ---- Problem 3 ---- ");
            rightTriangle();

            Console.WriteLine(" ---- Problem 4 ---- ");
            numberTriangle();

            Console.ReadKey();
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
        static void rightTriangle()
        {
            Console.WriteLine();
            for (int i = 1;i <= 4;i++)
            {
                for (int j = 0; j<i;j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();                
            }
        }
        static void numberTriangle()
        {   
            for (int i = 1; i<=4;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }                
                Console.WriteLine();
            }
            
        }

    }
}
