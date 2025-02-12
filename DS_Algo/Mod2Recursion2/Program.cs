namespace Mod2Recursion2
{
    internal class Program
    {
        static void PrintSquaresbyIteration(int n)
        {
            //while (n > 0)
            //{
            //    Console.WriteLine(n * n);
            //    n--;
            //}
            if (n > 0)
            {               
                Console.WriteLine(n*n);
                PrintSquaresbyIteration(n - 1);
            }
        }
        static void Square_HeadRecursion(int n)
        {
            if (n > 0)
            {
                Square_HeadRecursion(n-1);
                Console.WriteLine(n*n);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Print squares by iteration technique");
            PrintSquaresbyIteration(6);
            Console.WriteLine("Print squares by head");
            Square_HeadRecursion(6);


            Console.ReadKey();
        }
    }
}
