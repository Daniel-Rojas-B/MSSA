namespace Mod5Q_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customerNames = new Queue<string>();
            customerNames.Enqueue("Deepail");
            customerNames.Enqueue("Bob");
            customerNames.Enqueue("Dylan");

            foreach (string customerName in customerNames)
            {
                Console.WriteLine(customerName);
            }

            Console.WriteLine("After dequeue");
            customerNames.Dequeue();

            foreach (string customerName in customerNames)
            {
                Console.WriteLine(customerName + " ");
            }
            Class1 myq = new Class1(4);
            myq.Enqueue(1);
            myq.Enqueue(2);
            myq.Enqueue(3);
            myq.Enqueue(4);
            myq.Display();
            myq.Dequeue();
            myq.Dequeue();
            myq.Dequeue();
            myq.Dequeue();
            Console.WriteLine("after deq");
            myq.Display();
    

        }
    }
}
