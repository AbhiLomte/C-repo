using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            CheckIfNegative(number);

            Console.WriteLine("The number is non-negative.");
        }
        catch
        (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
                
        }
        catch (FormatException)
        {
            Console.WriteLine("please enter a valid integer:");
            catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occured:{ex.Message}");
        }
    }
    static void CheckIfNegative(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("The number is negative.");

        }
        Console.ReadLine();
    }
}
public class
    NegativeNumberException:
    Exception
{
    public NegativeNumberException(string message): base(message) { }
}
    
    

