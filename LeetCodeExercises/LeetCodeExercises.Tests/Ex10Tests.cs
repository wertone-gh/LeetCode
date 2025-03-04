#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex10Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string s, string p, bool expectedResult)
    {
        // Arrange
        var ex = new Ex10();

        // Act
        var result = ex.IsMatch(s, p);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "aa",
            "a",
            false
        ];

        yield return
        [
            "aa",
            "a*",
            true
        ];

        yield return
        [
            "ab",
            ".*",
            true
        ];
    }
}