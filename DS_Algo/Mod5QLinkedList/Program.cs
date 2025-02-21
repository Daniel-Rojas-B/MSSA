namespace Mod5QLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q myq = new Q();
            myq.Enqueue(23);
            myq.Enqueue(12);
            myq.Enqueue(13);
            myq.Enqueue(15);
            myq.Display();
            myq.Dequeue();
            myq.Display();
        }
    }
}
