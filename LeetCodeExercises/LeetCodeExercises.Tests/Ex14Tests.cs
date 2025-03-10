using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex14Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string[] input, string expectedResult)
    {
        // Arrange
        var ex = new Ex14();

        // Act
        var result = ex.LongestCommonPrefix(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { "flower", "flow", "flight" },
            "fl"
        ];

        yield return
        [
            new[] { "dog", "racecar", "car" },
            ""
        ];
    }
}