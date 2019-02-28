using System;

// Calculates area for a rectangle
public class AreaCalculator
{
    public double Area(Rectangle[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Width * shape.Height;
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

class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        var rectangle1 = new Rectangle();
        rectangle1.Width = 200;
        rectangle1.Height = 100;
        var rectangle2 = new Rectangle();
        rectangle2.Width = 300;
        rectangle2.Height = 100;
        Rectangle[] rectangles = new Rectangle[] { rectangle1, rectangle2 };
        areaCalculator.Area(rectangles);
    }
}