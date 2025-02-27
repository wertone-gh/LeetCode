namespace LeetCodeExercises;

public class Ex7
{
    public int Reverse(int number)
    {
        var result = 0;
        do
        {
            var value = number % 10;

            // Check if result will overflow before multiplying by 10 and adding value
            if (result > (int.MaxValue / 10) || (result == int.MaxValue / 10 && value > 7))
            {
                return 0;
            }

            if (result < (int.MinValue / 10) || (result == int.MinValue / 10 && value < -8))
            {
                return 0;
            }

            result = (result * 10) + value;
            number /= 10;
        } while (number != 0);

        return result;
    }
}