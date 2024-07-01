using System;

public class NegativeNumberException : Exception
{
    public NegativeNumberException()
    {
    }

    public NegativeNumberException(string message)
        : base(message)
    {
    }

    public NegativeNumberException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

public class que3
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            CheckNumber(number);
            Console.WriteLine("Input number is valid: " + number);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Negative number exception caught: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.Read();
    }

    public static void CheckNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("Negative numbers not allowed.");
        }
    }
}
