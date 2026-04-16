namespace NewDotNet.Intermediate.Section1.Classes;

public class Calculator
{
    public int Add(params int[] numbers)
    {
        var sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }
}