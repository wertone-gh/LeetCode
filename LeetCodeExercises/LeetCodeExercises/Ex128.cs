using System.Collections.Immutable;

namespace LeetCodeExercises;

public class Ex128
{
    public int LongestConsecutive(int[] nums)
    {
        var hashSet = nums.ToHashSet();
        var hashSetCount = hashSet.Count;
        if (hashSetCount is 0 or 1)
        {
            return hashSetCount;
        }

        var result = 0;
        foreach (var num in hashSet)
        {
            if (!hashSet.Contains(num - 1))
            {
                var count = 1;
                var currentNum = num;
                while (hashSet.Contains(currentNum + 1))
                {
                    count++;
                    currentNum++;
                }

                result = Math.Max(result, count);
            }
        }

        return result;
    }
}