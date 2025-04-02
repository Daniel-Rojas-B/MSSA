namespace Assignment12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1----");
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            RemoveNodes(head1, 6);
            Console.WriteLine();
            ListNode head2 = new ListNode();
            RemoveNodes(head2, 1);
            Console.WriteLine();
            ListNode head3 = new ListNode(7, new ListNode(7, new ListNode(7, new ListNode(7))));
            RemoveNodes(head3, 7);

            Console.ReadKey();
        }
        static void RemoveNodes(ListNode head, int val)
        {
            ListNode current = new ListNode(0, head);
            ListNode newHead = current;
            while (current.Next != null)
            {
                if (current.Next.Val == val)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                   current = current.Next;
                }
            }
            head = newHead.Next;
            while (head != null)
            {
                Console.Write(" " + head.Val );
                head = head.Next;
            }
        }
    }
}
