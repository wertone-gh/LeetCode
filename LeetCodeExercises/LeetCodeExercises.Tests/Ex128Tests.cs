#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex128Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] nums, int expectedResult)
    {
        // Arrange
        var ex = new Ex128();

        // Act
        var result = ex.LongestConsecutive(nums);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 100, 4, 200, 1, 3, 2 },
            4
        ];

        yield return
        [
            new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 },
            9
        ];

        yield return
        [
            new[] { 1, 0, 1, 2 },
            3
        ];
    }
}