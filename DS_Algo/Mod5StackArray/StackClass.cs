using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackArray
{
    internal class StackArray
    {
        private int[] data;
        private int top;
        public StackArray(int size)
        {
            this.data = new int[size];
            this.top = -1;
        }
        public bool IsEmpty()
        {
            return this.top == -1;
        }
        public bool IsFull()
        {
            return this.top == data.Length - 1;
        }
        public void Push(int val)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!, cannot push anymore items");
                return;
            }
            else
            {
                top++;
                data[top] = val;
            }

        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                return -1;
            }
            int val = data[top];
            top--;
            return val;
        }
        public int Peek()
        {
            if (IsEmpty()) { Console.WriteLine("Stack is empty"); return -1; }
            return data[top];

        }
        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
