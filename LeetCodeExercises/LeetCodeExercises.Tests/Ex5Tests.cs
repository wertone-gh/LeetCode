#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex5Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string input, string expectedResult)
    {
        // Arrange
        var ex = new Ex5();

        // Act
        var result = ex.LongestPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "babad",
            "aba"
        ];

        yield return
        [
            "cbbd",
            "bb"
        ];

        yield return
        [
            "a",
            "a"
        ];

        yield return
        [
            "abcba",
            "abcba"
        ];
    }
}