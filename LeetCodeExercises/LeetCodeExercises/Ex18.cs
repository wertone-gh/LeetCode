namespace LeetCodeExercises;

public class Ex18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (var i = 0; i < nums.Length - 3; i++)
        {
            if (i > 1 && nums[i] == nums[i - 1])
            {
                continue;
            }

            for (var k = nums.Length - 1; k >= i + 3; k--)
            {
                if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                {
                    continue;
                }

                int left = i + 1, right = k - 1;
                while (left < right)
                {
                    long total = (long)nums[i] + (long)nums[left] + (long)nums[right] + (long)nums[k];
                    if (total == target)
                    {
                        List<int> temp = [nums[i], nums[left], nums[right], nums[k]];
                        var exists = false;
                        foreach (var item in result)
                        {
                            if (item[0] == temp[0]
                                && item[1] == temp[1]
                                && item[2] == temp[2]
                                && item[3] == temp[3])
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (!exists)
                        {
                            result.Add(temp);
                        }

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
                    else if (total < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}