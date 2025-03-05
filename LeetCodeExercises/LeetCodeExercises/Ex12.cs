using System.Text;

namespace LeetCodeExercises;

public class Ex12
{
    public string IntToRoman(int num)
    {
        var romanNumerals = new[]
        {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500, Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100, Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50, Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10, Symbol = "X" },
            new { Value = 9, Symbol = "IX" },
            new { Value = 5, Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
            new { Value = 1, Symbol = "I" }
        };

        var result = new StringBuilder();

        foreach (var numeral in romanNumerals)
        {
            while (num >= numeral.Value)
            {
                result.Append(numeral.Symbol);
                num -= numeral.Value;
            }
        }

        return result.ToString();
    }
}