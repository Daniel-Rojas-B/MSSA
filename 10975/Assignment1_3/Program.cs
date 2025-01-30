using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            
            Console.WriteLine("Type the base of the triangle");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the height of the triangle");
            double num2 = double.Parse(Console.ReadLine());

            areaTriangle(num1, num2);

            Console.WriteLine("Type the side of the square");
            double side = double.Parse(Console.ReadLine());
            areaSquare(side);

            Console.WriteLine("Type the base of the rectangle");
            double baseValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the height of the rectangle");
            double height = double.Parse(Console.ReadLine());

            areaRectangle(baseValue, height);

            Console.WriteLine();

            Console.WriteLine(" ---- Problem 3 ----");
            Console.WriteLine("Test data:");
            Console.WriteLine("Input the number of elements to store in the array:");
            int numElements = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input {numElements} number of elements in the array:");
            iterationMethod(numElements);

            Console.ReadKey();
        }
        static void areaTriangle(double baseValue, double height)
        {
            double area = baseValue * height / 2;
            Console.WriteLine($"The area of the triangle with base {baseValue} and height {height} is {area}");
        }
        static void areaSquare(double side)
        {
            double area = side * side;
            Console.WriteLine($"The area of the square with side {side} is {area}");
        }
        static void areaRectangle(double baseValue, double height)
        {
            double area = baseValue * height;
            Console.WriteLine($"The area of the rectangle with base {baseValue} and height {height} is {area}");
        }
        static void iterationMethod(int numElements)
        {
            int[] numArray = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine($"element - {i}:");
            numArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i < numArray.Length; i++)
            {                
                Console.Write(numArray[i] + " ");                
            }
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are:");
            for (int i = numArray.Length - 1; i >= 0; i--)
            {                
                Console.Write(numArray[i] + " ");
            }

        }
    }
}
