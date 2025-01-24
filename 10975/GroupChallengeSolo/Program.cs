using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChallengeSolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Type element {i + 1}:");
                myArray[i] = int.Parse(Console.ReadLine());
            }  
            findMax(myArray);
            findMin(myArray);
        }
        static void findMax (int[] myArray)
        {
            int maxNumber = myArray[0];
            for (int i = 0;i < myArray.Length;i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine($"The max number is {maxNumber}");
        }
        static void findMin(int[] myArray)
        {
            int minNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minNumber)
                {
                    minNumber = myArray[i];
                }
            }
            Console.WriteLine($"The min number is {minNumber}");
        }
    }
}
