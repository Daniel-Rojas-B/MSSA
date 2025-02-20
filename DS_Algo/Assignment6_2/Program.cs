namespace Assignment6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            StackClass<string> myStack = new StackClass<string>(5);
            myStack.Push("Bob");
            myStack.Push("Dylan");
            myStack.Push("Jackson");
            myStack.Display();
            Console.WriteLine(" ---- After pop ---- ");
            myStack.Pop();
            myStack.Display();
            Console.WriteLine(" ---- Print Peek ---- ");
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            Console.WriteLine(" ---- Problem 2 ---- ");
            Console.WriteLine(string.Join(", ", ProductElements(new int[] { 1, 2, 3, 4 })));
            Console.WriteLine(string.Join(", ", ProductElements(new int[] { -1, 1, 0, -3, 3 })));


        }
        public static int[] ProductElements (int[] elements)
        {
            int length = elements.Length;
            int[] productsArray = new int[length];

            productsArray[0] = 1;
            for (int i = 1; i < length; i++)
            {
                productsArray[i] = productsArray[i - 1] * elements[i - 1];
            }
            
            int right = 1;
            for (int i = length-1; i >= 0; i--)
            {
                productsArray[i] = productsArray[i] * right;
                right = right * elements[i];
            }
            return productsArray;
        }
    }
}
