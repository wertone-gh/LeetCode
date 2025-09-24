namespace LeetCodeExercises;

public class Ex20
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var t in s)
        {
            switch (t)
            {
                case '{':
                    stack.Push('}');
                    continue;
                case '(':
                    stack.Push(')');
                    continue;
                case '[':
                    stack.Push(']');
                    continue;
            }

            if (stack is { Count: 0 } || stack.Pop() != t)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}