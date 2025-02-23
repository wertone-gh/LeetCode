namespace LeetCodeExercises;

public class Ex2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var currentL1Node = l1;
        var currentL2Node = l2;
        var controlVal = 0;
        var toAdd = 0;
        var resultNode = new ListNode();
        var currentResultNode = resultNode;
        while (true)
        {
            if (currentL1Node is not null)
            {
                currentResultNode.val += currentL1Node.val;
                currentL1Node = currentL1Node.next;
            }

            if (currentL2Node is not null)
            {
                currentResultNode.val += currentL2Node.val;
                currentL2Node = currentL2Node.next;
            }

            currentResultNode.val += toAdd;
            toAdd = currentResultNode.val / 10;
            var rest = currentResultNode.val % 10;
            currentResultNode.val = rest;
            controlVal += currentResultNode.val;
            if (currentL1Node is null && currentL2Node is null && toAdd == 0)
            {
                break;
            }

            currentResultNode.next = new ListNode();
            currentResultNode = currentResultNode.next;
        }

        if (controlVal == 0)
            return new ListNode();

        return resultNode;
    }

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
}