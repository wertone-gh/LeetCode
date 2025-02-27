namespace LeetCodeExercises;

public class Ex4
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var resultLength = nums1.Length + nums2.Length;
        var (leftMedianValue, rightMedianValue) = CalculateMedian(resultLength);

        var resultArray = new List<int>(resultLength);
        var array1Index = 0;
        var array2Index = 0;
        for (var counter = 0; counter < resultLength; counter++)
        {
            if (array1Index >= nums1.Length)
            {
                resultArray.Add(nums2[array2Index++]);
            }
            else if (array2Index >= nums2.Length)
            {
                resultArray.Add(nums1[array1Index++]);
            }
            else
            {
                resultArray.Add(nums1[array1Index] >= nums2[array2Index] ? nums2[array2Index++] : nums1[array1Index++]);
            }

            if (array1Index + array2Index == rightMedianValue)
            {
                if (leftMedianValue == rightMedianValue)
                {
                    return resultArray[rightMedianValue - 1];
                }

                return (resultArray[leftMedianValue - 1] + resultArray[rightMedianValue - 1]) / 2.0;
            }
        }

        return 0;
    }

    private static (int LeftMedian, int RightMedian) CalculateMedian(int resultLength)
    {
        var leftMedianValue = 0;
        var rightMedianValue = 0;
        if (resultLength % 2 == 0)
        {
            leftMedianValue = resultLength / 2;
            rightMedianValue = leftMedianValue + 1;
        }
        else
        {
            leftMedianValue = rightMedianValue = resultLength / 2 + 1;
        }

        return (leftMedianValue, rightMedianValue);
    }
}