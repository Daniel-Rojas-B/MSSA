using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 2 ----");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add (int, int)");
            Console.WriteLine("2. Add (decimal, decimal, decimal)");
            Console.WriteLine("3. Multiply (float, float)");
            Console.WriteLine("4. Multiply (float, float, float)");
            int opNumber = Int32.Parse(Console.ReadLine());

            switch (opNumber)
            {
                case 1:
                    Console.WriteLine("Enter two numbers");
                    int num1 = Int32.Parse(Console.ReadLine());
                    int num2 = Int32.Parse(Console.ReadLine());
                    int result1 = Mathops.add(num1, num2);
                    Console.WriteLine($"The result is: {result1}");
                    break;
                case 2:
                    Console.WriteLine("Enter three decimals numbers");
                    decimal num3 = decimal.Parse(Console.ReadLine());
                    decimal num4 = decimal.Parse(Console.ReadLine());
                    decimal num5 = decimal.Parse(Console.ReadLine());
                    decimal result2 = Mathops.add(num3, num4, num5 );
                    Console.WriteLine($"The result is: {result2}");
                    break;
                case 3:
                    Console.WriteLine("Enter two numbers");
                    float num6 = float.Parse(Console.ReadLine());
                    float num7 = float.Parse(Console.ReadLine());
                    float result3 = Mathops.multiply(num6, num7);
                    Console.WriteLine($"The result is: {result3}");
                    break;
                case 4:
                    Console.WriteLine("Enter three numbers");
                    float num8 = float.Parse(Console.ReadLine());
                    float num9 = float.Parse(Console.ReadLine());
                    float num10 = float.Parse(Console.ReadLine());
                    float result4 = Mathops.multiply(num8, num9, num10);
                    Console.WriteLine($"The result is: {result4}");
                    break;
            }

            Console.WriteLine(" ---- Problem 3 ---- ");
            Console.WriteLine("Type 1 for circle area or Type 2 for square area");
            int areaOption = Int32.Parse(Console.ReadLine());
            if (areaOption == 1 )
            {
                Console.WriteLine("Type the radius of the circle:");
                int radiusInput =  Int32.Parse(Console.ReadLine());
                Circle circle = new Circle();
                circle.Radius = radiusInput;
                Console.WriteLine($"The area of the circle is {circle.calculateArea()}");               
            }
            else if (areaOption == 2)
            {
                Console.WriteLine("Type the side of the square:");
                int sideInput = Int32.Parse(Console.ReadLine());
                Square square = new Square();
                square.Side = sideInput;
                Console.WriteLine($"The area of the square is {square.calculateArea()}");
            }


            Console.ReadKey();
        }
    }
}
