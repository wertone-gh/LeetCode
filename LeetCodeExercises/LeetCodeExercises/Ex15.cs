namespace LeetCodeExercises;

public class Ex15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                var total = nums[i] + nums[left] + nums[right];
                if (total == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right - 1])
                    {
                        right--;
                    }

                    left++;
                    right--;
                }
                else if (total < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}