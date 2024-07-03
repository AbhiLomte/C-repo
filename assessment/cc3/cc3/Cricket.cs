using System;

public class Cricket
{
    private int[] scores;

    
    public Cricket(int no_of_matches)
    {
        scores = new int[no_of_matches];
    }

   
    public void Pointscalculation()
    {
        int sum = 0;

        
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score for match {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            sum += scores[i];
        }

        
        double average = (double)sum / scores.Length;

        
        Console.WriteLine($"Sum of scores: {sum}");
        Console.WriteLine($"Average of scores: {average:F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of matches: ");
        int numMatches = Convert.ToInt32(Console.ReadLine());

        
        Cricket cricket = new Cricket(numMatches);

        
        cricket.Pointscalculation();
        Console.Read();
    }
}
