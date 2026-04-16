namespace NewDotNet.Intermediate.Section1.Classes;

public class MyClass
{
    public void MyMethod(int a)
    {
        a += 2;
        Console.WriteLine("Wierd, huhhh {0}", a);
    }
}

public class Weirdo
{
    public void DoAWeirdThing(ref int a)
    {
        a += 2;
    }
}