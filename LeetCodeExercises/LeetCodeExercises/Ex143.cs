namespace LeetCodeExercises;

public class Ex143
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null || head.next.next == null)
            return;

        var slow = head;
        var fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        ListNode prev = null;
        var current = slow.next;
        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        slow.next = null;

        var l1 = head;
        var l2 = prev;
        while (l2 != null)
        {
            ListNode next1 = l1.next, next2 = l2.next;
            l1.next = l2;
            l2.next = next1;
            l1 = next1;
            l2 = next2;
        }
    }
}