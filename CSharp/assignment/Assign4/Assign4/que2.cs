using System;

class que2
{
   public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Enter the letter to count:");
        char letterToCount = Console.ReadLine()[0]; 

        int count = CountOccurrences(inputString, letterToCount);

        Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the string.");
        Console.Read();
    }

    static int CountOccurrences(string str, char letter)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == letter)
            {
                count++;
            }
        }
        return count;
    }
}
