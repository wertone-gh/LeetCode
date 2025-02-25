using Xunit;

namespace LeetCodeExercises.Tests;

public class Ex4Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] nums1, int[] nums2, double expectedResult)
    {
        // Arrange
        var ex = new Ex4();

        // Act
        var result = ex.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 1, 3 },
            new[] { 2 },
            2.0
        ];

        yield return
        [
            new[] { 1, 2 },
            new[] { 3, 4 },
            2.5
        ];

        yield return
        [
            Array.Empty<int>(),
            new[] { 1 },
            1
        ];
    }
}