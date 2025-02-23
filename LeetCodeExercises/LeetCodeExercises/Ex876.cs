namespace LeetCodeExercises;

public class Ex876
{
    public ListNode MiddleNode(ListNode head)
    {
        var node = head;
        double count = 0;
        while (node is not null)
        {
            count++;
            node = node.next;
        }

        node = head;
        for (var i = 0; i < Math.Floor(count / 2); i++)
        {
            node = node.next;
        }

        return node;
    }

    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}