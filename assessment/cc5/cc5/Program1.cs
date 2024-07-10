using System;
using System.IO;

class Program1
{
    static void Main()
    {
        
        string filePath = "test.txt";

        
        string textToAppend = "This is some text to append.";

        try
        {
            // Create a new StreamWriter with append mode
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Append the text to the file
                writer.WriteLine(textToAppend);
            }

            Console.WriteLine("Text has been appended to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.Read();
    }
}
