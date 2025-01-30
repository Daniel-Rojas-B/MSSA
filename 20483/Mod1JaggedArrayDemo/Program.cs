using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1JaggedArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged array demo");
            int[][] temp_cities = new int[4][]; // decide number of cities
            {
                for (int i = 0; i < temp_cities.Length; i++)
                {
                    Console.WriteLine($"Enter the number of readings you expect for city {i}");
                    int readings = int.Parse(Console.ReadLine());
                    temp_cities[i]=new int[readings]; // allocate size to horizantal row
                    for (int j = 0; j < temp_cities[i].Length; j++) // how many in each row/city/array
                    {
                        Console.Write($"temp_cities [{i}][{j}]");
                        temp_cities[i][j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("temp readings");
                for (int i = 0; i<temp_cities.Length; i++)
                {
                    Console.Write($"city {i}:");
                    for (int j = 0; j<temp_cities[i].Length;j++)
                    {
                        Console.Write(temp_cities[i][j] + "F\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
