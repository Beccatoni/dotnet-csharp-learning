namespace NewDotNet.Intermediate.Section1.Classes.accessmodifiers;

public class Person2
{
    private DateTime _birthDate;
    public string Name { get; set; }
    public DateTime BirthDate { get; private set; }

    public Person2(DateTime birthDate)
    {
        BirthDate = birthDate;
    }

    public int Age
    {
        get
        {
           var timeSpan = DateTime.Today - BirthDate;
           var years = timeSpan.Days / 365;
           return years;
        }
    }
}