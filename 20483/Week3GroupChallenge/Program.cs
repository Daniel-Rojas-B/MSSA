using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3GroupChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Chocolates challenge ----");
            
            int[] pricesArray = { 4,2,1,3 };
            int money = 3;
            chocolates(pricesArray, money);
        }
        static void chocolates(int[] myArray, int budget )
        {
            int leftOver = budget;
            Array.Sort(myArray);  // ascending order
                                  // {1,2,3,4}
                       
            if (myArray[0] + myArray[1] <= budget)
            {
                    leftOver = budget - myArray[0] - myArray[1];                    
            }                
            
            Console.WriteLine($"You money leftover is: {leftOver}");

        }
    }
}
