// filepath: /Users/wertone/Code/LeetCode/LeetCode/LeetCodeExercises/LeetCodeExercises.Tests/Ex268Tests.cs
namespace LeetCodeExercises.Tests;

using System.Collections.Generic;
using Xunit;

public class Ex268Tests
{
    public static IEnumerable<object?[]> Examples => new List<object?[]>
    {
        // nums = [3,0,1] -> missing 2
        new object?[] { new int[] { 3, 0, 1 }, 2 },
        // nums = [0,1] -> missing 2
        new object?[] { new int[] { 0, 1 }, 2 },
        // nums = [9,6,4,2,3,5,7,0,1] -> missing 8
        new object?[] { new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8 }
    };

    [Theory]
    [MemberData(nameof(Examples))]
    public void MissingNumber_Examples(int[] nums, int expected)
    {
        var solver = new Ex268();
        var result = solver.MissingNumber(nums);
        Assert.Equal(expected, result);
    }
}

