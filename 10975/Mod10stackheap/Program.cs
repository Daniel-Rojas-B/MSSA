using System;
using System.Collections.Generic; // newer version for handling the data 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10stackheap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; // value type
            i = 10;
            object obj;
            obj = new object();
            obj = i; // when a value type is getting converted into reference this is known as boxing.

            int j;
            j = (int)obj; // ref type to value type is known as unboxing

            Stack mystack = new System.Collections.Generic.Stack();
            mystack.Push(i); // int boxing
            mystack.Push(4.5f); // float boxing

            

            mystack.Pop();

            int n1, n2;
            n1 = 56;
            n2 = 78;
            Swap(n1, n2);
            Console.WriteLine();
        }
        // {78, 23, 12, 67}
        static void Swap(int num1, int num2)
        {
            int temp = num2;
            num1 = num2;
            num2 = temp;
        }
    }
}
