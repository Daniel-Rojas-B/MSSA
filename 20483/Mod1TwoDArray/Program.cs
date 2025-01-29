using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1TwoDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] temperatures;
            //temperatures = new float[4, 4];
            // how to declare a 2d array: write the data type, square brackets [,], name of they array, new datatype, [rows, columns]

            //int[,,] ints = new int[2, 2, 2]; // 3d array declaration

            Console.WriteLine("2D array demo");
            Console.WriteLine("Enter the number of cities (rows)");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the temperatures received per city (cols)");
            int cols = int.Parse(Console.ReadLine());
            temperatures = new float[rows, cols];
            Console.WriteLine($"please enter {rows * cols} readings of temperatures");
            for (int i = 0; i < rows; i++) // outer loop
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"City [{i},{j}]");
                    temperatures[i, j] = float.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("The temperatures are:");
            for (int i = 0;i < temperatures.GetLength(0); i++)
            {
                for (int j = 0;j < temperatures.GetLength(1); j++)
                {
                    Console.Write(temperatures[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
