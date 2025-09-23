namespace LeetCodeExercises;

public class Ex139
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var memo = new Dictionary<string, bool>();
        var wordSet = new HashSet<string>(wordDict);
        return Dfs(s, wordSet, memo);
    }

    private bool Dfs(string s, HashSet<string> wordSet, Dictionary<string, bool> memo)
    {
        if (memo.TryGetValue(s, out var item))
        {
            return item;
        }

        if (wordSet.Contains(s))
        {
            return true;
        }

        for (var i = 1; i < s.Length; i++)
        {
            var prefix = s.Substring(0, i);
            if (wordSet.Contains(prefix) && Dfs(s.Substring(i), wordSet, memo))
            {
                memo[s] = true;
                return true;
            }
        }

        memo[s] = false;
        return false;
    }
}