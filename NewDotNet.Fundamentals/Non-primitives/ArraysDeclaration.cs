namespace NewDotNet.Fundamentals.Non_primitives;

public class ArraysDeclaration
{
    public void Arr()
    {
        int num1;
        int num2;
        int num3;

        var numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        
        var flags = new bool[3];
        flags[0] = true;
        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        var names = new string[3] { "Jack", "Jones", "Mary" };
    }
}