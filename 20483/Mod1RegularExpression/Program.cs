using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mod1RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            input:
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            if(ContainsDigits(name))
            {
                Console.WriteLine("Enter only letters");
                goto input;
            }
            else
            {
                emailInput:
                Console.WriteLine("Enter your email:");
                string email = Console.ReadLine();
                if (CheckEmail(email))
                {
                    Console.WriteLine($"{name}, you are registered");
                }
                else
                {
                    Console.WriteLine("Invalid email format pattern please re-enter");
                    goto emailInput;
                }
            }

        }
        static bool ContainsDigits(string s)
        {
            return Regex.IsMatch(s, "\\d");
        }
        static bool CheckEmail(string email)
        {
            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; 
            return Regex.IsMatch(email, emailpattern);
        }
    }
}
