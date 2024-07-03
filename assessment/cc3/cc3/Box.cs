using System;

public class Box
{
    
    public double Length { get; set; }
    public double Breadth { get; set; }

    
    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    
    public static Box AddBoxes(Box box1, Box box2)
    {
        double resultLength = box1.Length + box2.Length;
        double resultBreadth = box1.Breadth + box2.Breadth;

        return new Box(resultLength, resultBreadth);
    }

    
    public void DisplayBoxDetails()
    {
        Console.WriteLine($"Box Details:");
        Console.WriteLine($"Length: {Length} units");
        Console.WriteLine($"Breadth: {Breadth} units");
    }
}
