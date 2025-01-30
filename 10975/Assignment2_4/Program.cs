using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            SumArray();

            Console.WriteLine(" ---- Problem 2 ----");
            Largest();

            Console.WriteLine(" ---- Problem 3 ----");
            Console.WriteLine("Input the value for X coordinate:");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate:");
            int yCoordinate = int.Parse(Console.ReadLine());
            Coordinates(xCoordinate, yCoordinate);
        }
        public static void SumArray()
        {
            Console.WriteLine("Input the number of elements to be stored in the array:");
            int numElements = int.Parse(Console.ReadLine());
            int[] myArray = new int[numElements];
            int sumArray = 0;
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($"Element - {i+1}:");
                myArray[i] = int.Parse(Console.ReadLine());
                sumArray = sumArray + myArray[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {sumArray}");
        }
        public static void Largest()
        {
            int largestNumber =int.MinValue; // I use this method to initilize the variable with the int minimum value possible.
            int position = 0;
            
            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine($"Input number {i + 1}:");
                int comparisonNumber = int.Parse(Console.ReadLine());
                if ( comparisonNumber > largestNumber )
                {
                    largestNumber = comparisonNumber;
                    position = i + 1;
                }
            }
            Console.WriteLine($"The largest number is number {position}: {largestNumber}");
            
        }
        public static void Coordinates(int x, int y)
        {
            if ( x > 0 && y > 0 )
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
        }
    }
}
