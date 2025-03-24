using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex18Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] input, int target, int[][] expectedResult)
    {
        // Arrange
        var ex = new Ex18();

        // Act
        var result = ex.FourSum(input, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[]
            {
                1, 0, -1, 0, -2, 2
            },
            0,
            new[]
            {
                new[] { -2, -1, 1, 2 },
                new[] { -2, 0, 0, 2 },
                new[] { -1, 0, 0, 1 }
            }
        ];

        yield return
        [
            new[] { 2, 2, 2, 2, 2 },
            8,
            new[]
            {
                new[] { 2, 2, 2, 2 }
            }
        ];
    }
}