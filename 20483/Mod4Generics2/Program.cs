namespace Mod4Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = 23;
            n2 = 33;
            Swap<int> swapInt = new Swap<int>();
            swapInt.SwapData(ref n1, ref n2);

            Console.WriteLine("Hello, World!");
        }
    }
}
