#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex1Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] nums, int target, int[] expectedResult)
    {
        // Arrange
        var ex = new Ex1();

        // Act
        var result = ex.TwoSum(nums, target);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 2, 7, 11, 15 },
            9,
            new[] { 0, 1 }
        ];

        yield return
        [
            new[] { 3, 2, 4 },
            6,
            new[] { 1, 2 }
        ];

        yield return
        [
            new[] { 3, 3 },
            6,
            new[] { 0, 1 }
        ];
    }
}