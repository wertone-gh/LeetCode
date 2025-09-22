namespace LeetCodeExercises.Tests;

using Xunit;

public class Ex647Tests
{
    [Theory]
    [InlineData("abc", 3)] // a, b, c
    [InlineData("aaa", 6)] // a, a, a, aa, aa, aaa
    public void CountSubstrings_Examples(string s, int expected)
    {
        var solver = new Ex647();
        var result = solver.CountSubstrings(s);
        Assert.Equal(expected, result);
    }
}