#region

using Xunit;

#endregion

namespace LeetCodeExercises.Tests;

public class Ex2Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Test(int[] l1, int[] l2, int[] expectedResult)
    {
        // Arrange
        var ex = new Ex2();

        // Act
        var list1 = new Ex2.ListNode(l1[0], new Ex2.ListNode());
        var currentNodeL1 = list1.next;
        for (var i = 1; i < l1.Length; i++)
        {
            currentNodeL1.val = l1[i];
            if (i == l1.Length - 1)
            {
                break;
            }

            currentNodeL1.next = new Ex2.ListNode();
            currentNodeL1 = currentNodeL1.next;
        }

        var list2 = new Ex2.ListNode(l2[0], new Ex2.ListNode());
        var currentNodeL2 = list2.next;
        for (var i = 1; i < l2.Length; i++)
        {
            currentNodeL2.val = l2[i];
            if (i == l2.Length - 1)
            {
                break;
            }

            currentNodeL2.next = new Ex2.ListNode();
            currentNodeL2 = currentNodeL2.next;
        }

        var result = ex.AddTwoNumbers(list1, list2);

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
                2,
                4,
                3
            },
            new[]
            {
                5,
                6,
                4
            },
            new[]
            {
                7,
                0,
                8
            }
        ];

        yield return
        [
            new[]
            {
                0
            },
            new[]
            {
                0
            },
            new[]
            {
                0
            }
        ];

        yield return
        [
            new[]
            {
                9, 9, 9, 9, 9, 9, 9
            },
            new[]
            {
                9, 9, 9, 9
            },
            new[]
            {
                8, 9, 9, 9, 0, 0, 0, 1
            }
        ];
    }
}