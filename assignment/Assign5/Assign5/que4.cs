using System;

public interface IStudent
{
    
    int StudentId { get; set; }
    string Name { get; set; }

    
    void ShowDetails();
}

public class Dayscholar : IStudent
{
  
    public int StudentId { get; set; }
    public string Name { get; set; }

  
    public void ShowDetails()
    {
        Console.WriteLine($"Dayscholar Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}
public class Resident : IStudent
{
    
    public int StudentId { get; set; }
    public string Name { get; set; }

    
    public void ShowDetails()
    {
        Console.WriteLine($"Resident Details:");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
    }
}


class que4
{
    static void Main()
    {
        
        Dayscholar dayscholar = new Dayscholar();
        dayscholar.StudentId = 1006;
        dayscholar.Name = "Ravi Teja";
        dayscholar.ShowDetails();

        Console.WriteLine();

        
        Resident resident = new Resident();
        resident.StudentId = 2006;
        resident.Name = "Abhishek L";
        resident.ShowDetails();
        Console.Read();
    }
}
