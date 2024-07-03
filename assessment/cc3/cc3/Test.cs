public class Test
{
    public static void Main()
    {
        
        Box box1 = new Box(21.1,6.8);
        Box box2 = new Box(20.1, 5.4);

        
        Box box3 = Box.AddBoxes(box1, box2);

        
        Console.WriteLine("After adding the boxes:");
        box3.DisplayBoxDetails();
        Console.Read();
    }
}
