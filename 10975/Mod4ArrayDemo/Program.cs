using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Array is a collection of a fixed size, where memory is allocated continuously in heap memory. Elements can be accesed by their index.
             * datatype [] nameofarray = int [size]
             * 
             */
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine("Array demo");
            Console.WriteLine("Please enter 5 numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You entered the following numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            float[] temperatures = { 56.6f, 66f, 70.4f };

            Array.Resize(ref temperatures, 5);
            foreach(float f in temperatures)
            {
                Console.WriteLine(f);
            }

            string[] names = { "Zoe", "Amy", "Frank", "Nathan" };

            Array.Sort(names);
            Array.Reverse(numbers);
            Console.WriteLine("Reversed number array");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            // only use foreach loop while reading 
            Console.WriteLine("Sorted array is:");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("How many hobbies you have?");
            int numOfHobbies = int.Parse(Console.ReadLine());
            string[] hobbies = new string[numOfHobbies];
            Console.WriteLine($"Please enter {numOfHobbies} hobby/hobbies");

            for (int i = 0; i < numOfHobbies; i++)
            {
                Console.WriteLine($"Hobby[{i}]:");
                hobbies[i] = Console.ReadLine();
            }
            Console.WriteLine("great hobbies!");
            foreach(string s in hobbies)
            {
                Console.WriteLine(s);
            }

            List<string> cities = new List<string>();
            cities.Add

            Console.ReadKey();
        }
    }
}
