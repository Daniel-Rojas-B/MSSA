using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_2
{
    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value =0, ListNode next=null)
        {
            this.value = value; 
            this.next = next;
        }
    }
}
