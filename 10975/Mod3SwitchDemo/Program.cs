using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favColor;
            char choice = 'y';

            while(choice=='y' || choice=='Y')
            {
                Console.WriteLine("Enter favorite color (yellow, green, red, blue):");
                favColor = Console.ReadLine();

                switch(favColor.ToLower())
                {
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nice choice!");
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nice choice!");
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nice choice!");
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Nice choice!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("No such color");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to play again? (Y/N):");
                choice = char.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
