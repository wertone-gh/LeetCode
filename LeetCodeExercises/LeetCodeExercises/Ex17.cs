using System.Text;

namespace LeetCodeExercises;

public class Ex17
{
    private readonly Dictionary<char, char[]> _map = new()
    {
        { '2', ['a', 'b', 'c'] },
        { '3', ['d', 'e', 'f'] },
        { '4', ['g', 'h', 'i'] },
        { '5', ['j', 'k', 'l'] },
        { '6', ['m', 'n', 'o'] },
        { '7', ['p', 'q', 'r', 's'] },
        { '8', ['t', 'u', 'v'] },
        { '9', ['w', 'x', 'y', 'z'] }
    };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }

        GenerateCombination(digits, 0, new StringBuilder(), result);
        return result;
    }

    private void GenerateCombination(string digits, int index, StringBuilder currentCombination, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(currentCombination.ToString());
            return;
        }

        var digit = digits[index];
        if (_map.TryGetValue(digit, out var letters))
        {
            foreach (var letter in letters)
            {
                currentCombination.Append(letter);
                GenerateCombination(digits, index + 1, currentCombination, result);
                currentCombination.Remove(currentCombination.Length - 1, 1);
            }
        }
        else
        {
            GenerateCombination(digits, index + 1, currentCombination, result);
        }
    }
}