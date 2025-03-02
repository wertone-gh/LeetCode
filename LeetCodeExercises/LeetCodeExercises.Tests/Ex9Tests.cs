using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex9Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int input, bool expectedResult)
    {
        // Arrange
        var ex = new Ex9();

        // Act
        var result = ex.IsPalindrome(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            121,
            true
        ];

        yield return
        [
            -121,
            false
        ];

        yield return
        [
            10,
            false
        ];
    }
}