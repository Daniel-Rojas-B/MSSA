using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            ReturnEvenNumbers();

            Console.WriteLine(" ---- Problem 2 ----");
            LeapYear(2024);
            LeapYear(1900);
            LeapYear(2000);

            Console.WriteLine(" ---- Problem 3 ----");
            Console.WriteLine("Please input a string:");
            string text = Console.ReadLine();
            NumberSpaces(text);

            Console.WriteLine(" ---- Problem 4 ----");
            int[] numbers = { 0, 2, 1, 1, 9, 1, 1 };
            FirstOcurrence(numbers);

            Console.ReadKey();
        }

        static void ReturnEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(i).Append(" ");
                }
            }
            Console.WriteLine(sb);
        }

        static void LeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void NumberSpaces(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    counter++;
                }                
            }
            Console.WriteLine($"'{text}' contains {counter} spaces");
        }
        static void FirstOcurrence(int[] inputArray)
        {
            for (int i = 0;i < inputArray.Length;i++)
            {
                if (inputArray[i] == 1 && inputArray[i + 1] == 1)
                {
                    inputArray[i] = 0;
                    inputArray[i + 1] = 0;
                    break;
                }
            }
            Console.WriteLine(string.Join(", ",inputArray));
        }
    }
}
