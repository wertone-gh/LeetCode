namespace LeetCodeExercises;

public class Ex141
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public bool HasCycle(ListNode head)
    {
        var visited = new HashSet<ListNode>();
        var current = head;
        while (current != null)
        {
            if (!visited.Add(current))
            {
                return true;
            }

            current = current.next;
        }

        return false;
    }
}