namespace LeetCodeExercises.Tests;

using System.Collections.Generic;
using Xunit;

public class Ex139Tests
{
    public static IEnumerable<object?[]> Examples => new List<object?[]>
    {
        new object?[] { "leetcode", new List<string> { "leet", "code" }, true },
        new object?[] { "applepenapple", new List<string> { "apple", "pen" }, true },
        new object?[] { "catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }, false }
    };

    [Theory]
    [MemberData(nameof(Examples))]
    public void WordBreak_Examples(string s, IList<string> wordDict, bool expected)
    {
        var solver = new Ex139();
        var result = solver.WordBreak(s, wordDict);
        Assert.Equal(expected, result);
    }
}
