namespace NewDotNet.Fundamentals.Variables;

public static class Variables
{
    public static void Run()
    {
        var number = 2;
        var count = 10;
        var totalPrice = 20.95f;
        var character = 'A';
        var firstName = "Becca";
        var isWorking = false;
        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);

        Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);
        Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);
        Console.WriteLine("{0} {1}", double.MaxValue, double.MinValue);
        
        const float Pi = 3.14f;
        
        // Type  conversion
        byte b = 1;
        int i = b;
        byte c = (byte)i;
        float f = 1.0f;
        int a = (int)f;
        Console.WriteLine(a);
        Console.WriteLine(c);

        var number2 = "1234";
        int m = Convert.ToInt32(number2);
        Console.WriteLine(m);

        try
        {

           string str = "true";
           bool z = Convert.ToBoolean(str);
           Console.WriteLine(z);
        }
        catch (Exception e)
        { 
            Console.WriteLine("The number could not be converted to a byte.");
        }
        
        // Operators
        // Prefix increment
        int g = 1;
        int h = ++g;
        Console.WriteLine(h);
        Console.WriteLine(g);
        
        
    }
}