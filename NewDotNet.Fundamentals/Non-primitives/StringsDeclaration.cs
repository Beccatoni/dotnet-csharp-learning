namespace NewDotNet.Fundamentals.Non_primitives;

public class StringsDeclaration
{
    public void StringLearn()
    {
        string firstName = "Josh";
        string lastName = "Smith";
        string names = firstName + " " + lastName; // or
        string name = string.Format("{0} {1}", firstName, lastName);
        
        char fistChar = firstName[0];

        String girlName = "Jill";// the String class is the same as string keyword.

        var names1 = new string[] { "John", "Jack", "Jimmy" };
        var formattedNames = string.Join(",", names1);
        Console.WriteLine(formattedNames);
        
    }
}