namespace LeetCodeExercises.Tests;

using Xunit;

public class Ex20Tests
{
    [Theory]
    [InlineData("()", true)] // Example 1
    [InlineData("()[]{}", true)] // Example 2
    [InlineData("(]", false)] // Example 3
    [InlineData("([])", true)] // Example 4
    [InlineData("([)]", false)] // Example 5
    public void IsValid_Examples(string s, bool expected)
    {
        var solver = new Ex20();
        var result = solver.IsValid(s);
        Assert.Equal(expected, result);
    }
}