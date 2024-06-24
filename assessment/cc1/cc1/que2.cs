using System;

class program
{
    public static void Main()
    {
        
        string[] inputs = { "abcd", "a", "xy" };

        foreach (var input in inputs)
        {
            string result = SwapFirstAndLastCharacters(input);
            Console.WriteLine(result);
        }
        Console.Read();
    }

    static string SwapFirstAndLastCharacters(string str)
    {
        
        if (str.Length < 2)
        {
            return str;
        }

        
        char[] charArray = str.ToCharArray();

        
        char temp = charArray[0];
        charArray[0] = charArray[charArray.Length - 1];
        charArray[charArray.Length - 1] = temp;

      
        return new string(charArray);
    }
}
