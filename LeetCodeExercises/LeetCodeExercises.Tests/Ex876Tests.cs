#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex876Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] input, int[] expectedResult)
    {
        // Arrange
        var ex = new Ex876();

        // Act
        var head = new Ex876.ListNode(input[0], new Ex876.ListNode());
        var currentNode = head.next;
        for (var i = 1; i < input.Length; i++)
        {
            currentNode.val = input[i];
            if (i == input.Length - 1)
            {
                break;
            }

            currentNode.next = new Ex876.ListNode();
            currentNode = currentNode.next;
        }

        var result = ex.MiddleNode(head);

        var resultArray = new List<int>();
        while (result is not null)
        {
            resultArray.Add(result.val);
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedResult, resultArray);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[]
            {
                1,
                2,
                3,
                4,
                5
            },
            new[]
            {
                3,
                4,
                5
            }
        ];

        yield return
        [
            new[]
            {
                1,
                2,
                3,
                4,
                5,
                6
            },
            new[]
            {
                4,
                5,
                6
            }
        ];
    }
}