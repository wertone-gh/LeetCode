namespace LeetCodeExercises;

public class Ex10
{
    public bool IsMatch(string input, string pattern)
    {
        var inputLength = input.Length;
        var patternLength = pattern.Length;
        var dp = new bool[inputLength + 1, patternLength + 1];
        dp[0, 0] = true;

        for (var j = 1; j <= patternLength; j++)
        {
            if (pattern[j - 1] == '*')
            {
                dp[0, j] = dp[0, j - 2];
            }
        }

        for (var i = 1; i <= inputLength; i++)
        {
            for (var j = 1; j <= patternLength; j++)
            {
                if (pattern[j - 1] == '.' || pattern[j - 1] == input[i - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else if (pattern[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (input[i - 1] == pattern[j - 2] || pattern[j - 2] == '.'));
                }
            }
        }

        return dp[inputLength, patternLength];
    }
}