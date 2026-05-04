namespace NewDotNet.Intermediate.Section2;

public class ModularCalculator
{
    private double num1;
    private double num2;
    private double result;

    public ModularCalculator(double num1, double num2, double result = 0)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.result = result;
        Console.WriteLine("---------------");
        Console.WriteLine("Caculator Program");
        Console.WriteLine("---------------");
    }

    public void Addition()
    {
        result = num1 + num2;
        Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, result);
    }

    public void Subtraction()
    {
        result = num1 - num2;
        Console.WriteLine("Subtraction: {0} - {1} = {2}", num1, num2, result);
    }

    public void Multiplication()
    {
        result = num1 * num2;
        Console.WriteLine("Multiplication: {0} * {1} = {2}", num1, num2, result);
    }

    public void Division()
    {
        try
        {
            result = num1 / num2;
            Console.WriteLine("Division: {0} / {1} = {2}", num1, num2, result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}