using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            MatrixFormat();

            Console.WriteLine(" ---- Problem 2 ----");
            Console.WriteLine("Input the size of the square matrix (less than 5):");
            int size = int.Parse(Console.ReadLine());
            SumMatrix(size);

            Console.WriteLine(" ---- Problem 4 ----");
            decimal total;
            decimal average;
            Console.WriteLine("Enter the First number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number:");
            int fourth = int.Parse(Console.ReadLine());
            TotalAverage(out average, out total, first,second,third, fourth);
            Console.WriteLine($"The average of {first},{second},{third},{fourth} is: {average}");
            Console.WriteLine($"The total is {total}");

            Console.WriteLine(" ---- Problem 5 ----");
            FindIndex(new int[] { 9, 8, 3 }, 3);

            Console.ReadKey();
        }
        static void MatrixFormat()
        {
            float[,] matrixNumbers = new float[2, 3];
            for (int i = 0; i < matrixNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumbers.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter number to be stored in matrix position [{i+1},{j+1}]");
                    matrixNumbers[i,j] = float.Parse(Console.ReadLine());
                }                
            }
            for (int i = 0;i < matrixNumbers.GetLength(0);i++)
            {
                for (int j = 0;j < matrixNumbers.GetLength(1);j++)
                {
                    Console.Write(matrixNumbers[i,j] + "|" );
                }
                Console.WriteLine();
            }
        }
        static void SumMatrix (int sizeMatrix)
        {                      
            
            float[,] matrix1 = new float[sizeMatrix, sizeMatrix];
            float[,] matrix2 = new float[sizeMatrix, sizeMatrix];
            float[,] sumMatrix = new float[sizeMatrix, sizeMatrix];

            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i<matrix1.GetLength(0); i++)
            {
                for (int j = 0; j<matrix1.GetLength(1); j++)
                {                    
                    Console.WriteLine($"element - [{i},{j}]:");
                    matrix1[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the second matrix :");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {                    
                    Console.WriteLine($"element - [{i},{j}]:");
                    matrix2[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("The first matrix is:");

            for (int i = 0; i< matrix1.GetLength(0); i++)
            {
                for (int j = 0;j<matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine("The second matrix is:");

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The addition of two matrix is:");

            for (int i = 0; i < sumMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sumMatrix.GetLength(1); j++)
                {
                    sumMatrix[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            for (int i = 0; i < sumMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sumMatrix.GetLength(1); j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void TotalAverage(out decimal average, out decimal total, params int[] numbers)
        {
            average = 0;
            total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }
            average = total / numbers.Length;           
        }

        static void FindIndex(int[] array, int number)
        {
            int index = -1;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] == number)
                {
                    index = i;                    
                }                       
                
            }
            Console.WriteLine(index);
        }

    }
}
