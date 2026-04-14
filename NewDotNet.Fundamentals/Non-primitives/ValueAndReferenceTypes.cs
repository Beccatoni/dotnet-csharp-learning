namespace NewDotNet.Fundamentals.Non_primitives;

public class ValueAndReferenceTypes
{
    public void Run()
    {
        // Value types
        var a = 10;
        var b = a;
        b++;
        Console.WriteLine("a: {0}, b: {1}", a, b); // a: 10, b:11
        
        
        // Reference types
        var array1 = new int[3]  { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 4;
        Console.WriteLine(array1[0]);

        var num = 1;
        Increment(num);
        Console.WriteLine(num);

        var person = new Person3() { Age = 30 };
        MakeOld(person);
        Console.WriteLine(person.Age);

    }
    
    public static void Increment(int number)
    {
        number+= 10;
    }
    
     public static void MakeOld(Person3 person)
    {
        person.Age+=10;
    }
}

public class Person3
{
    public int Age;
}