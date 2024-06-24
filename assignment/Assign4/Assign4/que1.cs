using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Display(firstName, lastName);
        Console.Read();

    }

    public static void Display(string firstName, string lastName)
    {
        string upperFirstName = firstName.ToUpper();
        string upperLastName = lastName.ToUpper();

        Console.WriteLine(upperFirstName);
        Console.WriteLine(upperLastName);
    }
}
