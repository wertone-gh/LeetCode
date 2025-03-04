namespace LeetCodeExercises;

public class Ex11
{
    public int MaxArea(int[] height)
    {
        var n = height.Length;
        var maxArea = 0;
        var left = 0;
        var right = n - 1;
        var maxLeft = 0;
        var maxRight = 0;

        while (true)
        {
            maxLeft = Math.Max(height[left], maxLeft);
            maxRight = Math.Max(height[right], maxRight);

            if (left == right)
            {
                return maxArea;
            }

            if (height[left] <= height[right])
            {
                maxArea = Math.Max(maxArea, (right - left) * maxLeft);
                left++;
            }
            else
            {
                maxArea = Math.Max(maxArea, (right - left) * maxRight);
                right--;
            }
        }
    }
}