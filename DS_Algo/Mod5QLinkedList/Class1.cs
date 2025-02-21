using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5QLinkedList
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }
    }
    public class Q
    {
        Node front;
        Node rear;
        int size;

        public Q()
        {
            this.front = null;
            this.rear = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void Enqueue(int val)
        {
            Node newNode = new Node(val, null);

            if (IsEmpty())
            {
                front = newNode;
            }
            else
            {
                rear.next = newNode;
            }
            rear = newNode;
            size++;
        }
        public int? Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Q is empty");
                return null;
            }
            int val = front.data;
            front = front.next;
            size--;
            if (IsEmpty())
            {
                rear = null;
            }
            return val;
        }
        public void Display()
        {
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }

}
