using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12_2
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int value=0, ListNode head=null)
        {
            Val = value;
            Next = head;
        }
    }    
}
