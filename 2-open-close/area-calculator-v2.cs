using System;

public class AreaCalculator
{
    // Violation : Not closed for Modification | Not open for extension
    // Needs modification for every new shape
    public double Area(object[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                area += rectangle.Width * rectangle.Height;
            }
            else
            {
                Circle circle = (Circle)shape;
                area += circle.Radius * circle.Radius * Math.PI;
            }

            Console.WriteLine(area);
        }

        return area;
    }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class Circle
{
    public double Radius { get; set; }
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
        Object[] shapes = new Object[] { rectangle, circle };
        areaCalculator.Area(shapes);
    }
}