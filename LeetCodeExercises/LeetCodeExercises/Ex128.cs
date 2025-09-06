namespace LeetCodeExercises;

public class Ex128
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);

        if (nums.Length is 0 or 1)
        {
            return nums.Length;
        }

        var result = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            var current = nums[i];
            var prev = nums[i - 1];

            if (current == prev)
            {
                continue;
            }

            if (current != prev + 1)
            {
                break;
            }

            result++;
        }

        return result;
    }
}