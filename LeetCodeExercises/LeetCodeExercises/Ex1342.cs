namespace LeetCodeExercises;

public class Ex1342
{
    public int NumberOfSteps(int input)
    {
        var steps = 0;
        if (input == 0) return steps;
        if (input % 2 == 0)
        {
            steps++;
            return steps + NumberOfSteps(input / 2);
        }
        else
        {
            steps++;
            return steps + NumberOfSteps(input - 1);
        }
    }
}