#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex6Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string input, int numRows, string expectedResult)
    {
        // Arrange
        var ex = new Ex6();

        // Act
        var result = ex.Convert(input, numRows);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "PAYPALISHIRING",
            3,
            "PAHNAPLSIIGYIR"
        ];

        yield return
        [
            "PAYPALISHIRING",
            4,
            "PINALSIGYAHRPI"
        ];

        yield return
        [
            "A",
            1,
            "A"
        ];

        yield return
        [
            "AB",
            1,
            "AB"
        ];

        yield return
        [
            "ABC",
            2,
            "ACB"
        ];
    }
}