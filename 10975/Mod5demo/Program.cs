using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float result;
        inputnumbers:
            Console.WriteLine("enter 2 numbers:");
            Console.WriteLine("enter two numbers");

            // 3o
            bool flag1 = int.TryParse(Console.ReadLine(), out num1);
            bool flag2 = int.TryParse(Console.ReadLine(),out num2);
            try
            {

           
                if (flag1 && flag2 )
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result is {result}");
                }
                else
                {
                    Console.WriteLine("numbers are invalid, please reenter");
                    goto inputnumbers;
                }
            }
            catch(FileNotFoundException ex)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter non zero denominator");
                goto inputnumbers;
            }
            Console.ReadKey();
        }
    }
}
