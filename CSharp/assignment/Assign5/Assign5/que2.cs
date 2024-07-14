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
        double newLength = box1.Length + box2.Length;
        double newBreadth = box1.Breadth + box2.Breadth;

        return new Box(newLength, newBreadth);
    }
}

public class que2
{
    public static void Main()
    {
     
        Box box1 = new Box(3.5, 4.5);
        Box box2 = new Box(2.0, 3.0);

        
        Box resultBox = Box.AddBoxes(box1, box2);

        
        Console.WriteLine("Dimensions of Result Box:");
        Console.WriteLine($"Length: {resultBox.Length}, Breadth: {resultBox.Breadth}");
        Console.Read();
    }
}
