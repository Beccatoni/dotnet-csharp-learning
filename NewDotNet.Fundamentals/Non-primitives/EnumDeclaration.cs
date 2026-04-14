namespace NewDotNet.Fundamentals.Non_primitives;

public enum ShippingMethod
{
    RegularAirMail,
    RegisteredAirMail,
    ExpressAirMail,
}

public class EnumDeclaration
{
    public void Enums()
    {
        var method = ShippingMethod.ExpressAirMail;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);
    }
}