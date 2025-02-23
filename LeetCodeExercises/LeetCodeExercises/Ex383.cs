namespace LeetCodeExercises;

public class Ex383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        if (ransomNote == magazine)
        {
            return true;
        }

        var freq = new int[26];
        foreach (var c in magazine)
        {
            freq[c - 'a']++;
        }

        foreach (var c in ransomNote)
        {
            if (--freq[c - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}