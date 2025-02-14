namespace Mod3Fibonacci
{
    internal class Program
    {
        static Nullable<long>[] sequence = new Nullable<long>[100];
        // 0,1,1,2,3
        // O(n)
        static int Fibonacci_Iteration(int n)
        {
            int first = 0, second = 1, result = 0;
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                Console.Write(0);
                return 1;
            }
            Console.Write("0" + ",1,");
            for (int i = 2; i < n; i++)
            {
                result = first + second;
                Console.Write(result + ",");
                first = second;//move them to right
                second = result;

            }
            return result;

        }

        //pure recursion
        static int Fib_Recursion(int n)
        {
            if (n <= 1) return n;
            return Fib_Recursion(n - 1) + Fib_Recursion(n - 2);
        }
        // recursion+DP
        static long? Fib_RecDP(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return sequence[n] = Fib_RecDP(n - 1) + Fib_RecDP(n - 2);
        }

        // DP
        static int[] FibDp(int n)
        {
            if (n < 1) return new int[0]; // Return empty array if n < 1
            if (n == 1) return new int[] { 0 }; // Special case for n = 1

            int[] series = new int[n]; // Array of size n
            series[0] = 0;
            if (n > 1) series[1] = 1; // Only set series[1] if n > 1

            for (int i = 2; i < n; i++) // Loop stops at n (not n+1)
            {
                series[i] = series[i - 1] + series[i - 2];
            }
            return series;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fib by iteration");
            Fibonacci_Iteration(8);
            
            Console.WriteLine();
            Console.WriteLine(Fib_Recursion(8));
            Console.WriteLine();

            Console.WriteLine("Recursion +DP");
            Fib_RecDP(8);
            foreach (var i in sequence)
            {
                if (i.HasValue)
                    Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Dynamic prog");
            var results = FibDp(8);
            foreach (var i in results)
            {
                Console.Write(i+ " ");
            }
            Console.ReadKey();
        }
    }
}
