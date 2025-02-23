#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex1342Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int input, int expectedResult)
    {
        // Arrange
        var ex = new Ex1342();

        // Act
        var result = ex.NumberOfSteps(input);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            14,
            6
        ];

        yield return
        [
            8,
            4
        ];

        yield return
        [
            123,
            12
        ];
    }
}