using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex13Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string input, int expectedResult)
    {
        // Arrange
        var ex = new Ex13();

        // Act
        var result = ex.RomanToInt(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "III",
            3
        ];

        yield return
        [
            "LVIII",
            58
        ];

        yield return
        [
            "MCMXCIV",
            1994
        ];
    }
}