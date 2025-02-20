using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1
{
    internal class Node
    {
        public int HouseId { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        //public int data;
        public Node next;

        public Node(int HouseId, string Address, string HouseType, Node next)
        {
            this.HouseId = HouseId;
            this.Address = Address;
            this.HouseType = HouseType;
            //this.data = data;
            this.next = next;
        }

    }

    class LList
        {
            private Node head;
            private Node tail;
            private int size;

            public int Size
            {
                get { return size; }
            }
            public LList ()
            {
                this.head = null;
                this.tail = null;
                this.size = 0;
            }
            public bool IsEmpty()
            {
                return this.size == 0;
            }
            public void AddFirst(int houseNumber, string address, string houseType)
            {
                Node newNode = new Node(houseNumber, address, houseType, null);
                if (IsEmpty())
                {
                    this.head= newNode;
                    this.tail= newNode;
                }
                else
                {
                    newNode.next = this.head;
                    this.head = newNode;
                }
                size++;
            }
            public void Display()
            {
                Node temp = this.head;
                if (IsEmpty() )
                {
                    Console.WriteLine("The list is empty");
                }
                else
                {
                    while ( temp != null )
                    {
                        
                            Console.WriteLine($"House Number: {temp.HouseId}, Address: {temp.Address}, Type: {temp.HouseType}");
                            temp = temp.next;
                        
                    }
                }
            }
            public void Search(int houseId)
            {
                Node temp = this.head;
                while ( temp != null )
                {
                    if (temp.HouseId == houseId)
                    {
                        Console.WriteLine(" ---- House Found ---- ");
                        Console.WriteLine($"House Id: {temp.HouseId}");
                        Console.WriteLine($"Address: {temp.Address}");
                        Console.WriteLine($"Type: {temp.HouseType}");
                        return;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("House not Found");
            }
        }
    }

