namespace NewDotNet.Intermediate.Section2;

public abstract class Drawing
{
    public int Width { get; }
    public int Height { get; }

    public abstract void Draw();

    public void Copy()
    {
        Console.WriteLine("Copu shape into clipboard");
    }
    
    public void Select()
    {
        Console.WriteLine("Select a shape");
    }
}

public class Circle2 : Drawing
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Circle");
    }
}

public class Rectangle2 : Drawing
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Rectangle");
    }
}