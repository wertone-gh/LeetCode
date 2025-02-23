#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex412Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int n, IList<string> expectedResult)
    {
        // Arrange
        var ex = new Ex412();

        // Act
        var result = ex.FizzBuzz(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            3,
            new[]
            {
                "1",
                "2",
                "Fizz"
            }
        ];

        yield return
        [
            5,
            new[]
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz"
            }
        ];

        yield return
        [
            15,
            new[]
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            }
        ];
    }
}