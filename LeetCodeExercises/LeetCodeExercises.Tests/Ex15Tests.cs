using Xunit;
using System.Linq;

namespace LeetCodeExercises.Tests;

public class Ex15Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] input, int[][] expectedResult)
    {
        // Arrange
        var ex = new Ex15();

        // Act
        var result = ex.ThreeSum(input);

        // Assert (porównanie niezależne od kolejności tripletów i ich kolejności wewnętrznej)
        var normalizedExpected = expectedResult
            .Select(t => t.OrderBy(x => x).ToArray())
            .OrderBy(t => t[0]).ThenBy(t => t[1]).ThenBy(t => t[2])
            .Select(t => string.Join(",", t))
            .ToList();

        var normalizedActual = result
            .Select(t => t.OrderBy(x => x).ToArray())
            .OrderBy(t => t[0]).ThenBy(t => t[1]).ThenBy(t => t[2])
            .Select(t => string.Join(",", t))
            .ToList();

        Assert.Equal(normalizedExpected, normalizedActual);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[]
            {
                -1, 0, 1, 2, -1, -4
            },
            new[]
            {
                new[] { -1, 0, 1 },
                new[] { -1, -1, 2 }
            }
        ];

        // brak rozwiązania -> spodziewamy się pustej listy
        yield return
        [
            new[] { 0, 1, 1 },
            new int[][] { }
        ];

        yield return
        [
            new[]
            {
                0, 0, 0
            },
            new[]
            {
                new[] { 0, 0, 0 }
            }
        ];
    }
}