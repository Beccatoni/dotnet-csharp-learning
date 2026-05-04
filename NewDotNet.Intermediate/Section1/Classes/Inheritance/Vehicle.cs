namespace NewDotNet.Intermediate.Section1.Classes.Inheritance;

public class Vehicle
{
    private readonly string _registrationNumber;

    // public Vehicle()
    // {
    //     Console.WriteLine("Vehicle is being initialized.");
    // }

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }
}