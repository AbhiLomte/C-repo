using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        List<int> numbers = new List<int> { 7, 2, 30 };
        List<string> results = GetNumbersAndSquaresGreaterThan20(numbers);

        foreach (string result in results)
        {
            Console.WriteLine("→ " + result);
        }
        Console.Read();
    }

    static List<string> GetNumbersAndSquaresGreaterThan20(List<int> numbers)
    {
        List<string> results = new List<string>();

        foreach (int num in numbers)
        {
            int square = num * num;
            if (square > 20)
            {
                results.Add($"{num} - {square}");
            }
        }

        return results;
    }
}
