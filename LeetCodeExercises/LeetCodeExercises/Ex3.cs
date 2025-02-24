namespace LeetCodeExercises;

public class Ex3
{
    private readonly Dictionary<char, int> _chars = new();

    public int LengthOfLongestSubstring(string input)
    {
        if (input.Length is 0 or 1)
        {
            return input.Length;
        }

        var longestSubstring = 0;
        var currentSubstring = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (_chars.ContainsKey(input[i]))
            {
                currentSubstring = i - _chars[input[i]];
                _chars.Remove(input[i]);
            }
            else
            {
                currentSubstring++;
            }

            longestSubstring = Math.Max(longestSubstring, currentSubstring);
            _chars.Add(input[i], i);
        }

        return longestSubstring;
    }
}