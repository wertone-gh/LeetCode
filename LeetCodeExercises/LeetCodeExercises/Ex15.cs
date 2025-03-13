namespace LeetCodeExercises;

public class Ex15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new HashSet<List<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            var firstNumber = nums[i];
            for (var j = i + 1; j < nums.Length; j++)
            {
                var secondNumber = nums[j];
                for (var k = j + 1; k < nums.Length; k++)
                {
                    var thirdNumber = nums[k];
                    if (firstNumber + secondNumber + thirdNumber == 0)
                    {
                        List<int> temp = [firstNumber, secondNumber, thirdNumber];
                        temp.Sort();
                        result.Add(temp);
                    }
                }
            }
        }

        return result.Select(x => (IList<int>)x.ToList())
            .ToList();
    }
}