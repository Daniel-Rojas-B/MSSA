using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    internal class Program
    {
                
        static void Main(string[] args)
        {            
            char choice = 'y';

            Console.WriteLine("---- Problem 1 ----");

            while (choice == 'y' || choice == 'Y') 
            {
                Console.WriteLine("Please enter two integers to check if they are equal or not");
                int num1 = Int32.Parse(Console.ReadLine());
                int num2 = Int32.Parse(Console.ReadLine());
                checkNumbers(num1, num2);
                Console.WriteLine();
                Console.WriteLine("Do you want to check again? (y/Y) or (n/N)");
                choice = char.Parse(Console.ReadLine());                
            }

            Console.WriteLine();
            Console.WriteLine("Press any button to continue to problem 2");
            Console.ReadKey(true);
            Console.WriteLine("---- Problem 2 ----");
            first10Numbers();
            Console.WriteLine();
            Console.WriteLine("---- Problem 3 ----");
            Console.WriteLine();
            Console.WriteLine("Welcome to my calculator");
            Console.WriteLine();
            Console.WriteLine("Please enter two numbers to perform an arithmetic operation");
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());
            calculator(number1, number2);

            Console.ReadKey();
        }
        static void checkNumbers(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
                
        }
        static void first10Numbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is {sum}");
        }
        static void calculator(int num1, int num2)
        {
            int option;
            
            char choice = 'y';

            while (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Please enter an option from below");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Substraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");

                option = Int32.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        
                        Console.WriteLine($"Addition between {num1} and {num2} is {num1+num2}");
                        break;
                    case 2:
                        //int result = num1 - num2;
                        Console.WriteLine($"Difference between {num1} and {num2} is {num1-num2}");
                        break;
                    case 3:
                        //int result = num1 * num2;
                        Console.WriteLine($"Multiplication between {num1} and {num2} is {num1*num2}");
                        break;
                    case 4:
                        //int result = num1 / num2;
                        Console.WriteLine($"Division between {num1} and {num2} is {num1/num2}");
                        break;
                    default:                        
                        Console.WriteLine("No such option");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to play again? (Y/N):");
                choice = char.Parse(Console.ReadLine());
            }
           
        }

    }
}
