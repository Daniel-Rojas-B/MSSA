using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            // print even numbers from 2 to 50
            for (int i = 2; i <= 50; i = i+2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("--------------");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // 5!=5*4*3*2*1
            // 6!=6*5*4*3*2*1
            int num = 5;
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            int j = 1;
            while(j<=20)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.ReadKey();
        }
    }
}
