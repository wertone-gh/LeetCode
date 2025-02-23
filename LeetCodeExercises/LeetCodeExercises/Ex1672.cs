namespace LeetCodeExercises;

public class Ex1672
{
    public int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;
        foreach (var account in accounts)
        {
            var wealth = 0;
            foreach (var money in account)
            {
                wealth += money;
            }

            maxWealth = Math.Max(maxWealth, wealth);
        }

        return maxWealth;
    }
}