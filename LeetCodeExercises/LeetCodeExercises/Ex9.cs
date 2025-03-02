namespace LeetCodeExercises;

public class Ex9
{
    public bool IsPalindrome(int x)
    {
        var input = x.ToString();
        var length = input.Length;
        for (var i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}