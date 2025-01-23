using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExtraAssignments_week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            Console.WriteLine("What is the current temperature in Fahrenheit?:");
            int temperature = int.Parse(Console.ReadLine());
            TempMessage(temperature);

            Console.WriteLine(" ---- Problem 2 ----");
            
            Validation();

            Console.WriteLine(" ---- Problem 3 ----");

            Triangle();

            Console.ReadKey();
        }
        public static void TempMessage(int temperature)
        {
            if (temperature >= 0 && temperature <= 10)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature >= 11 && temperature <= 20)
            {
                Console.WriteLine("Very cold weather");
            }
            else if (temperature >= 21 && temperature <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature >= 36 && temperature <= 50)
            {
                Console.WriteLine("Normal weather");
            }
            else if (temperature >= 51 && temperature <= 65)
            {
                Console.WriteLine("It's hot");
            }
            else if (temperature >= 66 && temperature <= 80)
            {
                Console.WriteLine("It's very hot");
            }
        }
        public static void Validation()
        {
            string correctUserId = "dani90";
            string correctPassword = "abc123";
            int incorrectEntries = 0;

            while (incorrectEntries < 3)
            {
                Console.WriteLine("Type the user id");
                string userId = Console.ReadLine();
                Console.WriteLine("Type the password");
                string password = Console.ReadLine();

                if (userId == correctUserId && password == correctPassword)
                {
                    Console.WriteLine("User id and Password matched");
                    return;
                }
                else
                {
                    Console.WriteLine("User id or Password do not match, please try again");
                    incorrectEntries++;
                }
            }
            Console.WriteLine("Attempts have exceeded the limit allowed");
            
        }
        public static void Triangle()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width:");
            int width = int.Parse(Console.ReadLine());

            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
