using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex11Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] height, int expectedResult)
    {
        // Arrange
        var ex = new Ex11();

        // Act
        var result = ex.MaxArea(height);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 },
            49
        ];

        yield return
        [
            new[] { 1, 1 },
            1
        ];
    }
}