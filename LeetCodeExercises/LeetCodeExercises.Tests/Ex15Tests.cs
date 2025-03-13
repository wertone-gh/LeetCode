using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex15Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] input, int[][] expectedResult)
    {
        // Arrange
        var ex = new Ex15();

        // Act
        var result = ex.ThreeSum(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[]
            {
                -1, 0, 1, 2, -1, -4
            },
            new[]
            {
                new[] { -1, 0, 1 },
                new[] { -1, -1, 2 }
            }
        ];

        yield return
        [
            new[] { 0, 1, 1 },
            new[]
            {
                new int[] { }
            }
        ];

        yield return
        [
            new[]
            {
                0, 0, 0
            },
            new[]
            {
                new[] { 0, 0, 0 }
            }
        ];
    }
}