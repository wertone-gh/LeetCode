namespace LeetCodeExercises;

public class Ex1
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
            return [0, 1];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        return [];
    }
}