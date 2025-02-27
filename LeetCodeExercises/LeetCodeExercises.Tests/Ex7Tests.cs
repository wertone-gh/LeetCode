#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex7Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int input, int expectedResult)
    {
        // Arrange
        var ex = new Ex7();

        // Act
        var result = ex.Reverse(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            123,
            321
        ];

        yield return
        [
            -123,
            -321
        ];

        yield return
        [
            120,
            21
        ];
    }
}