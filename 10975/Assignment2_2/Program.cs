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
