#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex8Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string input, int expectedResult)
    {
        // Arrange
        var ex = new Ex8();

        // Act
        var result = ex.MyAtoi(input);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "  0000000000012345678",
            12345678
        ];

        yield return
        [
            "42",
            42
        ];

        yield return
        [
            " -042",
            -42
        ];

        yield return
        [
            "1337c0d3",
            1337
        ];

        yield return
        [
            "0-1",
            0
        ];

        yield return
        [
            "words and 987",
            0
        ];

        yield return
        [
            "    0000000000000   ",
            0
        ];

        yield return
        [
            "   +0 123",
            0
        ];

        yield return
        [
            "21474836460",
            2147483647
        ];

        yield return
        [
            "-2147483648",
            -2147483648
        ];
    }
}