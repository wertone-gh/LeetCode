namespace LeetCodeExercises;

public class Ex13
{
    private readonly Dictionary<char, int> _romanNumerals = new()
    {
        { 'M', 1000 },
        { 'D', 500 },
        { 'C', 100 },
        { 'L', 50 },
        { 'X', 10 },
        { 'V', 5 },
        { 'I', 1 }
    };


    public int RomanToInt(string s)
    {
        var length = s.Length;
        if (length == 0)
        {
            return 0;
        }

        var result = 0;
        var prevValue = 0;
        for (var i = length - 1; i >= 0; i--)
        {
            var currentValue = _romanNumerals[s[i]];
            if (currentValue < prevValue)
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }

            prevValue = currentValue;
        }

        return result;
    }
}