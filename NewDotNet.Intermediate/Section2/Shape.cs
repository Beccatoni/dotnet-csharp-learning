namespace NewDotNet.Intermediate.Section2;

public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    public virtual void Draw()
    {
    }
}

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }
}

public enum ShapeType
{
    Square,
    Diamond,
    Triangle
}

public class Canvas
{
    public void DrawShapes(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
                shape.Draw();
        }
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Rectangle");
    }
}

public class Triangle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Triangle");
    }
}

public class Diamond : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Diamond");
    }
}