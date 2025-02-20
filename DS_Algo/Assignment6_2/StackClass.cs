using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6_2
{
    internal class StackClass<T>
    {
        private T[] elements;
        private int top;

        public StackClass(int size)
        {
            this.elements = new T[size];
            this.top = -1;
        }
        public bool IsEmpty()
        {
            return this.top == -1;
        }
        public bool IsFull()
        {
            return this.top == elements.Length - 1;
        }
        public void Push(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!, cannot push anymore items");
                return;
            }
            else
            {
                top++;
                elements[top] = element;
            }         
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                return default(T);
            }
            T val = elements[top];
            top--;
            return val;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot get peek");
                return default(T);
            }
            return elements[top];
        }
        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(elements[i]);
            }
        }
       
    }
}
