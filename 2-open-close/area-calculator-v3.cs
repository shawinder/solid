using System;

class AreaCalculator
{
    // Passed : Closed for modification | Open for Extension
    // Any number of shapes can be added without modification
    public double Area(Shape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
            Console.WriteLine(area);
        }

        return area;
    }
}

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        var rectangle = new Rectangle();
        rectangle.Width = 200;
        rectangle.Height = 100;
        var circle = new Circle();
        circle.Radius = 10;
        Shape[] shapes = new Shape[] { rectangle, circle };
        areaCalculator.Area(shapes);
    }
}