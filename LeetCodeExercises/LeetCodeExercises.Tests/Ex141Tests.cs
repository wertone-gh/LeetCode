namespace LeetCodeExercises.Tests;

using System.Collections.Generic;
using Xunit;

public class Ex141Tests
{
    public static IEnumerable<object?[]> Examples => new List<object?[]>
    {
        // head = [3,2,0,-4], pos = 1 -> cycle at node with value 2
        new object?[] { new int[] { 3, 2, 0, -4 }, 1, true },
        // head = [1,2], pos = 0 -> cycle at head
        new object?[] { new int[] { 1, 2 }, 0, true },
        // head = [1], pos = -1 -> no cycle
        new object?[] { new int[] { 1 }, -1, false }
    };

    [Theory]
    [MemberData(nameof(Examples))]
    public void HasCycle_Examples(int[] values, int pos, bool expected)
    {
        var solver = new Ex141();
        var head = BuildListWithCycle(values, pos);
        var result = solver.HasCycle(head);
        Assert.Equal(expected, result);
    }

    private static Ex141.ListNode BuildListWithCycle(int[] values, int pos)
    {
        if (values.Length == 0) return null;
        var nodes = new Ex141.ListNode[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            nodes[i] = new Ex141.ListNode(values[i]);
            if (i > 0)
            {
                nodes[i - 1].next = nodes[i];
            }
        }
        if (pos >= 0 && pos < nodes.Length)
        {
            nodes[^1].next = nodes[pos];
        }
        return nodes[0];
    }
}

