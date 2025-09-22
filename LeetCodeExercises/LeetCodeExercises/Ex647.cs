namespace LeetCodeExercises;

public class Ex647
{
    public int CountSubstrings(string s)
    {
        var ans = s.Length;
        for (var i = 0; i < s.Length; i++)
        {
            var left = i - 1;
            var right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                ans++;
                left--;
                right++;
            }

            left = i;
            right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                ans++;
                left--;
                right++;
            }
        }

        return ans;
    }
}