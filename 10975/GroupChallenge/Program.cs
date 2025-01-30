using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChallenge
{
    internal class Program
    {
        // Function to find the largest number in the array
        static int FindLargest(int[] arr)
        {
            int largest = arr[0]; // Assume the first element is the largest
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num; // Update largest if a larger number is found
                }
            }
            return largest;
        }

        // Function to find the smallest number in the array
        static int FindSmallest(int[] arr)
        {
            int smallest = arr[0]; // Assume the first element is the smallest
            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    smallest = num; // Update smallest if a smaller number is found
                }
            }
            return smallest;
        }

        // Main method
        static void Main()
        {
            int[] arr = new int[10]; // Array to store 10 integers

            // Taking input from the user for the array
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()); // Read the integer input
            }

            // Find the largest and smallest number
            int largest = FindLargest(arr);
            int smallest = FindSmallest(arr);

            // Output the results
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The smallest number is: {smallest}");
        }
    }

}
