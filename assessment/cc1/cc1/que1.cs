using System;


namespace cc1
{
    class que1
    {
        static void Main()
        {
            
            Console.WriteLine("After we remove character at position 1 the string will be :"+RemoveCharacterAtPosition("Python", 1)); 
          

            Console.Read();
        }

        static string RemoveCharacterAtPosition(string str, int index)
        {
            
            if (index < 0 || index >= str.Length)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of range.");
            }

            
            return str.Remove(index, 1);
        }
    }
}
