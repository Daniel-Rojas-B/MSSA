using System;
using System.Reflection;

namespace Assignment5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Problem 1----");
            DisplayDigits(1234);

            Console.WriteLine();

            Console.WriteLine("----Problem 2----");
            Console.WriteLine("Input the size of the matrix");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            Console.WriteLine("Input the elements in the matrix");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"element - {i},{j}:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Addition of the right Diagonal elements is: " + RightDiagonal(matrix, size-1));

            Console.ReadKey();
        }
        static void DisplayDigits(int n)
        {
            if (n == 0) 
                return;
            DisplayDigits(n / 10);
            Console.Write(n % 10 + " ");          
        }
        static int RightDiagonal(int[,] matrix, int index )
        {
            if (index < 0) return 0; 

            
            return matrix[index, index] + RightDiagonal(matrix, index - 1);
        }
    }
}
