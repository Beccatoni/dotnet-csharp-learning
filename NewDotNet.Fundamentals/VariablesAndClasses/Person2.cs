namespace NewDotNet.Fundamentals.Variables;

public class Person2
{
    public string FistName;
    public string LastName;

    public void Introduce()
    {
        Console.WriteLine("My name is {0} {1}", FistName, LastName);
    }
}