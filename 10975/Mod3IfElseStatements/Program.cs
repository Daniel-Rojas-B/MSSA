using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3IfElseStatements
{
    internal class Program
    {
        static void CheckSpeed(int speed)
        {
            if (speed > 55)
            {
                if (speed > 55 && speed < 65)
                {
                    Console.WriteLine("Within limits");
                }
                else if (speed > 65 && speed <= 85)
                {
                    Console.WriteLine("Bracket 1 fine");
                }
                else if (speed > 85)
                {
                    Console.WriteLine("Take away license");
                }

            }
            else
            {
                Console.WriteLine("Waiting for next vehicle");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Speed Checker ");
            Console.WriteLine("Enter vehicle speed:");
            int speed = Int32.Parse(Console.ReadLine());   
            CheckSpeed(speed);

            Console.ReadKey();

        }
    }
}
