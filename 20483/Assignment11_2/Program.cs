namespace Assignment11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1 ----");
            int[] prices1 = new int[] { 7, 1, 5, 3, 6, 4 };
            StockProfit(prices1);
            int[] prices2 = new int[] { 7, 6, 4, 3, 1 };
            StockProfit(prices2);

            Console.WriteLine("---- Problem 2 ----");
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            ReversedList(head1);
            ListNode head2 = new ListNode(1, new ListNode(2, null));
            ReversedList(head2);
            ListNode head3 = new ListNode();
            ReversedList(head3);

        }

        public static void StockProfit(int[] prices)
        {
            int min_price = int.MaxValue; 
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_price)
                {
                    min_price = prices[i];
                }
                else
                {
                    if (prices[i] - min_price > profit)
                    {
                        profit = prices[i]-min_price;
                    }
                }
            }
            Console.WriteLine(profit);
        }
        public static void ReversedList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            
            while (current != null)
            {
                ListNode next = current.next;  
                current.next = prev;           
                prev = current;                
                current = next;                
            }
            
            ListNode reversedHead = prev;
            while (reversedHead != null)
            {
                Console.Write(reversedHead.value + " ");
                reversedHead = reversedHead.next;
            }

            Console.WriteLine();
        }
    }
}
