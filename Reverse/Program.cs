using System;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? cur = head;
        ListNode? prev = null;
        ListNode? nxt = null;
        while (cur != null)
        {
            nxt = cur.next;
            cur.next = prev;
            prev = cur;
            cur = nxt;
        }

        return prev;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode? reversedHead1 = solution.ReverseList(head1);
        PrintList(reversedHead1);

        // Example 2
        ListNode head2 = new ListNode(1, new ListNode(2));
        ListNode? reversedHead2 = solution.ReverseList(head2);
        PrintList(reversedHead2);

        // Example 3
        ListNode? head3 = null;
        ListNode? reversedHead3 = solution.ReverseList(head3);
        PrintList(reversedHead3);
    }

    public static void PrintList(ListNode? head)
    {
        if (head == null)
        {
            Console.WriteLine("[]");
            return;
        }

        Console.Write("[");
        ListNode? current = head;
        while (current != null)
        {
            Console.Write(current.val);
            current = current.next;
            if (current != null)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}