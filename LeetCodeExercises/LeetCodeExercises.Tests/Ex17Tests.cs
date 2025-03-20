using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex17Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string digits, string[] expectedResult)
    {
        // Arrange
        var ex = new Ex17();

        // Act
        var result = ex.LetterCombinations(digits);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "23",
            new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
        ];

        yield return
        [
            "",
            new string[] { }
        ];

        yield return
        [
            "2",
            new[] { "a", "b", "c" }
        ];
    }
}