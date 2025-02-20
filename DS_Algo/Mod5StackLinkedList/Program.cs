namespace Mod5StackLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL myStack = new StackLL();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Display();
            Console.WriteLine("after pop");
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Display();
            Console.ReadKey();
        }
    }
}
