namespace LeetCodeExercises;

public class Ex5
{
    public string LongestPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        int start = 0, end = 0;
        for (var i = 0; i < input.Length; i++)
        {
            var len1 = ExpandAroundCenter(input, i, i);
            var len2 = ExpandAroundCenter(input, i, i + 1);
            var len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        return input.Substring(start, end - start + 1);
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}