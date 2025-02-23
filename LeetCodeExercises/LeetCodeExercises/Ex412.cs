#region

using System.Text;

#endregion

namespace LeetCodeExercises;

public class Ex412
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new List<string>(n);
        for (var i = 1; i <= n; i++)
        {
            var sb = new StringBuilder();
            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }

            if (sb.Length == 0)
            {
                sb.Append(i.ToString());
            }

            result.Add(sb.ToString());
        }

        return result;
    }
}