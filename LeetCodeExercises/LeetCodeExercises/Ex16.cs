namespace LeetCodeExercises;

public class Ex16
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = 0;
        var closest = int.MaxValue;
        for (var i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                var total = nums[i] + nums[left] + nums[right];
                if (total == target)
                {
                    return total;
                }

                var temp = Math.Abs(target - total);
                if (temp < closest)
                {
                    result = total;
                    closest = temp;
                }

                if (total > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return result;
    }
}