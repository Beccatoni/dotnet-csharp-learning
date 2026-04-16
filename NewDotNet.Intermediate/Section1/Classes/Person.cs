namespace NewDotNet.Intermediate.Section1.Classes;

public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine("Hi {0}, I am {1}", to, Name);
    }

    public static Person Parse(string toParse)
    {
        var person = new Person();
        person.Name = toParse;
        return person;
    }
}