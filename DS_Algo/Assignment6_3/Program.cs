using static Assignment6_3.Customer;

namespace Assignment6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q myq = new Q();
            myq.Enqueue(1, "Daniel");
            myq.Enqueue(2, "Chester");
            myq.Enqueue(3, "Danny");            
            myq.Display();
            myq.Dequeue();
            Console.WriteLine("After dequeueing");
            myq.Display();
            myq.Dequeue();
            myq.Dequeue();
            myq.Dequeue();
        }
    }
}
