using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Methoddemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateTax(baseSalary: 64900, state: "ny", filingType: 'M', dependents: 0, contributions: 345);
            CalculateTax(baseSalary: 23456, state: "ca", filingType: 'Y', contributions: 232, dependents: 1);
            int sum;
            long product;
            int[] values = { 67, 89, 34, 90 };
            // if there are multiple return types of different datatypes then use out
            Results( out sum, out product, values );
            Console.WriteLine($"sum: {sum} and product: {product}");

            Results(out sum, out product, 1,2);
            Console.WriteLine($"sum: {sum} and product: {product}");

            Results(out sum, out product, 1,2,3);
            Console.WriteLine($"sum: {sum} and product: {product}");


            Console.ReadKey();
        }
        //static bool TryParse(string s, out int result)
        //{

        //}
        static void Add(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        static int Add(int i, int j, int k)
        {
            return i + j + k;
        }
        // optional paramteres must be at the end in the method declaration
        // 
        static void CalculateTax(double baseSalary, double contributions, string state, int dependents, char filingType)
        {
           //logic
           
        }
        static void Results(out int sum, out long product, params int[] values)
        {
            product = 1;
            sum = 0;
            foreach(int i in values)
            {
                product = product * i;
                sum = sum + i;
            }
        }     

        
    }
}
