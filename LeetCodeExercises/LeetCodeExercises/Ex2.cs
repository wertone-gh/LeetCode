namespace LeetCodeExercises;

public class Ex2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var currentL1Node = l1;
        var currentL2Node = l2;
        var carry = 0;
        var controlVal = 0;
        var resultNode = new ListNode();
        var currentResultNode = resultNode;

        while (currentL1Node != null || currentL2Node != null || carry != 0)
        {
            var sum = carry;

            if (currentL1Node != null)
            {
                sum += currentL1Node.val;
                currentL1Node = currentL1Node.next;
            }

            if (currentL2Node != null)
            {
                sum += currentL2Node.val;
                currentL2Node = currentL2Node.next;
            }

            carry = sum / 10;
            currentResultNode.next = new ListNode(sum % 10);
            currentResultNode = currentResultNode.next;
            controlVal += currentResultNode.val;
        }

        if (controlVal == 0)
        {
            return new ListNode();
        }

        return resultNode.next;
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