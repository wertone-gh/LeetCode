namespace LeetCodeExercises;

public class Ex8
{
    public int MyAtoi(string s)
    {
        var input = s.AsSpan().Trim();
        if (input.Length == 0)
        {
            return 0;
        }

        int i = 0, sign = 1, result = 0;

        if (input[i] == '-' || input[i] == '+')
        {
            sign = input[i] == '-' ? -1 : 1;
            i++;
        }

        while (i < input.Length && char.IsDigit(input[i]))
        {
            var digit = input[i] - '0';

            // Check for overflow before updating result
            if (result > (int.MaxValue - digit) / 10)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            i++;
        }

        return sign * result;
    }
}