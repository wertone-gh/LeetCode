using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex12Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int input, string expectedResult)
    {
        // Arrange
        var ex = new Ex12();

        // Act
        var result = ex.IntToRoman(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            3749,
            "MMMDCCXLIX"
        ];

        yield return
        [
            58,
            "LVIII"
        ];

        yield return
        [
            1994,
            "MCMXCIV"
        ];
    }
}