#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex383Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(string ransomNote, string magazine, bool expectedResult)
    {
        // Arrange
        var ex = new Ex383();

        // Act
        var result = ex.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "a",
            "b",
            false
        ];

        yield return
        [
            "aa",
            "ab",
            false
        ];

        yield return
        [
            "aa",
            "aab",
            true
        ];
    }
}