namespace NewDotNet.Fundamentals.StringsLearn;

public class Strings
{
    public void Run()
    {
        var fullName = "John Doe ";
        Console.WriteLine("Untrimmed: '{0}', Trimmed: {1}", fullName, fullName.Trim());
        Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());
        
        var index = fullName.LastIndexOf(' ');
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);
        Console.WriteLine("FirstName: " + firstName);
        Console.WriteLine("LastName: " + lastName);

        var names = fullName.Split(' ');
        Console.WriteLine("FirstName: " + names[0]);
        Console.WriteLine("LastName: " + names[1]);

        fullName.Replace("John", "Johnbcde");
        Console.WriteLine(fullName);
    }
}