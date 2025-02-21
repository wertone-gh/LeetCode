namespace LeetCodeExercises;

public class Ex1672
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;
        foreach (var account in accounts)
        {
            int wealth = 0;
            foreach (var money in account)
            {
                wealth += money;
            }

            maxWealth = Math.Max(maxWealth, wealth);
        }

        return maxWealth;
    }
}