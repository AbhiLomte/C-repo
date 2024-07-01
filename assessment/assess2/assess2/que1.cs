using System;


abstract class Student
{
    
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    
    public abstract bool IsPassed(double grade);
}


class Undergraduate : Student
{
    
    public Undergraduate(string name, int studentId, double grade)
    {
        Name = name;
        StudentId = studentId;
        Grade = grade;
    }

    
    public override bool IsPassed(double grade)
    {
        if (grade > 70.0)
            return true;
        else
            return false;
    }
}

class Graduate : Student
{
    
    public Graduate(string name, int studentId, double grade)
    {
        Name = name;
        StudentId = studentId;
        Grade = grade;
    }

    
    public override bool IsPassed(double grade)
    {
        if (grade > 80.0)
            return true;
        else
            return false;
    }
}


class que1
{
    static void Main()
    {
        
        Undergraduate undergrad = new Undergraduate("Ganesh", 1006, 75.5);
        Graduate grad = new Graduate("Rahul", 2006, 85.0);

       
        Console.WriteLine("Undergraduate:");
        Console.WriteLine($"Name: {undergrad.Name}");
        Console.WriteLine($"Student ID: {undergrad.StudentId}");
        Console.WriteLine($"Grade: {undergrad.Grade}");
        Console.WriteLine($"Passed: {undergrad.IsPassed(undergrad.Grade)}");

        Console.WriteLine();

        Console.WriteLine("Graduate:");
        Console.WriteLine($"Name: {grad.Name}");
        Console.WriteLine($"Student ID: {grad.StudentId}");
        Console.WriteLine($"Grade: {grad.Grade}");
        Console.WriteLine($"Passed: {grad.IsPassed(grad.Grade)}");

        Console.ReadLine();
    }
}
