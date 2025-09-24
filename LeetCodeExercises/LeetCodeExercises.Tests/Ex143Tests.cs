namespace LeetCodeExercises.Tests;

using System.Collections.Generic;
using Xunit;

public class Ex143Tests
{
    public static IEnumerable<object?[]> Examples => new List<object?[]>
    {
        // Input: [1,2,3,4] -> Output: [1,4,2,3]
        new object?[] { new int[] { 1, 2, 3, 4 }, new int[] { 1, 4, 2, 3 } },
        // Input: [1,2,3,4,5] -> Output: [1,5,2,4,3]
        new object?[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 5, 2, 4, 3 } }
    };

    [Theory]
    [MemberData(nameof(Examples))]
    public void ReorderList_Examples(int[] input, int[] expected)
    {
        var solver = new Ex143();
        var head = BuildList(input);

        solver.ReorderList(head);

        var actual = ToArray(head);
        Assert.Equal(expected, actual);
    }

    private static Ex143.ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new Ex143.ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new Ex143.ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static int[] ToArray(Ex143.ListNode head)
    {
        var list = new List<int>();
        var current = head;
        while (current != null)
        {
            list.Add(current.val);
            current = current.next;
        }
        return list.ToArray();
    }
}