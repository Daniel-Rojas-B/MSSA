using System.Diagnostics;

namespace Mod2Recursion3
{
    internal class Program
    {
        // n=5 1+2+3+4+5 = sum(4) + 5
        // finding sum of all number in series 1 to n

        static int Sum_Recursion(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;
            return Sum_Recursion(n-1)+n;
        }

        static int Sum_Iteration(int n)
        {
            int sum = 0;
            int i=1;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum_Iteration(5));
            Console.WriteLine(Sum_Recursion(5));
        }
    }
}
