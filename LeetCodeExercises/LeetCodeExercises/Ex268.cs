namespace LeetCodeExercises;

using System;

public class Ex268
{
    public int MissingNumber(int[] nums)
    {
        var originalSum = 0;
        var expectedSum = 0;
        for (var i = 0; i < nums.Length + 1; i++)
        {
            if (i < nums.Length)
                originalSum += nums[i];

            expectedSum += i;
        }

        return expectedSum - originalSum;
    }
}