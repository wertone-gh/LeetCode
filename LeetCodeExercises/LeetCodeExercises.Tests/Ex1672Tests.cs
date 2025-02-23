#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex1672Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[][] accounts, int expectedResult)
    {
        // Arrange
        var ex = new Ex1672();

        // Act
        var result = ex.MaximumWealth(accounts);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[]
            {
                new[] { 1, 2, 3 },
                new[] { 3, 2, 1 }
            },
            6
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 5 },
                new[] { 7, 3 },
                new[] { 3, 5 }
            },
            10
        ];

        yield return
        [
            new[]
            {
                new[] { 2, 8, 7 },
                new[] { 7, 1, 3 },
                new[] { 1, 9, 5 }
            },
            17
        ];
    }
}