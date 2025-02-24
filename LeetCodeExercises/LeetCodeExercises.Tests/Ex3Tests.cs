using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex3Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string input, int expectedResult)
    {
        // Arrange
        var ex = new Ex3();

        // Act
        var result = ex.LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "abcabcbb",
            3
        ];

        yield return
        [
            "bbbbb",
            1
        ];

        yield return
        [
            "pwwkew",
            3
        ];

        yield return
        [
            " ",
            1
        ];

        yield return
        [
            "au",
            2
        ];

        yield return
        [
            "dvdf",
            3
        ];

        yield return
        [
            "abba",
            2
        ];
    }
}