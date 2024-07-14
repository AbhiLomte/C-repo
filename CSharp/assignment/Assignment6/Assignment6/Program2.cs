using System;
using System.Collections.Generic;
using System.Linq;

class Program2
{
    static void Main()
    {
        List<string> words = new List<string> { "mum", "amsterdam", "bloom" };


        var query = from word in words
                    where word.ToLower().StartsWith("a") && word.ToLower().EndsWith("m")
                    select word;


        List<string> resultList = query.ToList();


        if (resultList.Count > 0)
        {
            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in resultList)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("No words found starting with 'a' and ending with 'm'.");
        }
        Console.Read();
    }
}
