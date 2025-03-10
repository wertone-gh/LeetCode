using System.Text;

namespace LeetCodeExercises;

public class Ex14
{
    public string LongestCommonPrefix(string[] strs)
    {
        var length = strs.Length;
        if (length == 0)
        {
            return "";
        }

        if (length == 1)
        {
            return strs[0];
        }

        var firstString = strs[0];
        var longestPrefix = new StringBuilder();
        for (var i = 1; i < length; i++)
        {
            var currentPrefixForWord = new StringBuilder();
            for (var j = 0; j < strs[i].Length; j++)
            {
                if (firstString.Length > j && firstString[j] == strs[i][j])
                {
                    currentPrefixForWord.Append(firstString[j]);
                }
                else
                {
                    break;
                }
            }

            if (currentPrefixForWord.Length == 0)
            {
                return "";
            }

            if (longestPrefix.Length == 0)
            {
                longestPrefix.Append(currentPrefixForWord);
            }

            if (currentPrefixForWord.Length < longestPrefix.Length)
            {
                longestPrefix.Clear();
                longestPrefix.Append(currentPrefixForWord);
            }
        }

        return longestPrefix.ToString();
    }
}