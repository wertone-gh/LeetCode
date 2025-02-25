namespace LeetCodeExercises;

public class Ex3
{
    public int LengthOfLongestSubstring(string input)
    {
        int n = input.Length;
        int maxLength = 0;
        int left = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for (int right = 0; right < n; right++)
        {
            char currentChar = input[right];

            // If we find a repeating character, move the left pointer
            if (charIndexMap.ContainsKey(currentChar))
            {
                left = Math.Max(left, charIndexMap[currentChar] + 1);
            }

            // Update the last seen index of the current character
            charIndexMap[currentChar] = right;

            // Calculate the window size and update the max length
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}