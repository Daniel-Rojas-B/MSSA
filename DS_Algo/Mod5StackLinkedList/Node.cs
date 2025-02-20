using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackLinkedList
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int value, Node next)
        {
            this.data = value;
            this.next = next;
        }
    }
    class StackLL
    {
        Node top;
        int size;
        public StackLL()
        {
            this.top = null;
            this.size = 0;
        }
        public bool isEmpty ()
        {
            return this.size == 0;
        }
        public void Push (int val)
        {
            Node newNode = new Node(val, null);
            if (isEmpty ())
            {
                this.top = newNode;
            }
            else
            {
                newNode.next = this.top;
                this.top = newNode;
            }
            size++;
        }
        public int Pop()
        {
            if (isEmpty ())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int val = top.data;
            top = top.next;
            size--;
            return val;
        }
        public int Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.data;
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");               
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
