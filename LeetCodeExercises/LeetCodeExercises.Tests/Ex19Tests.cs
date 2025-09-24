namespace LeetCodeExercises.Tests;

using System.Collections.Generic;
using Xunit;

public class Ex19Tests
{
    public static IEnumerable<object?[]> Examples => new List<object?[]>
    {
        // Input: [1,2,3,4,5], n = 2 -> [1,2,3,5]
        new object?[] { new int[] { 1,2,3,4,5 }, 2, new int[] { 1,2,3,5 } },
        // Input: [1], n = 1 -> []
        new object?[] { new int[] { 1 }, 1, new int[] { } },
        // Input: [1,2], n = 1 -> [1]
        new object?[] { new int[] { 1,2 }, 1, new int[] { 1 } }
    };

    [Theory]
    [MemberData(nameof(Examples))]
    public void RemoveNthFromEnd_Examples(int[] input, int n, int[] expected)
    {
        var solver = new Ex19();
        var head = BuildList(input);

        var result = solver.RemoveNthFromEnd(head, n);
        var actual = ToArray(result);

        Assert.Equal(expected, actual);
    }

    private static Ex19.ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new Ex19.ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new Ex19.ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static int[] ToArray(Ex19.ListNode head)
    {
        if (head == null) return new int[] { };
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