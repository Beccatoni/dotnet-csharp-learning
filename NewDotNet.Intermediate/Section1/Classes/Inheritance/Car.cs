namespace NewDotNet.Intermediate.Section1.Classes.Inheritance;

public class Car : Vehicle
{
        public Car(string registrationNumber): base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
}