using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex16Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] input, int target, int expectedResult)
    {
        // Arrange
        var ex = new Ex16();

        // Act
        var result = ex.ThreeSumClosest(input, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { -1, 2, 1, -4 },
            1,
            2
        ];

        yield return
        [
            new[] { 0, 0, 0 },
            1,
            0
        ];

        yield return
        [
            new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 },
            1,
            60
        ];
    }
}