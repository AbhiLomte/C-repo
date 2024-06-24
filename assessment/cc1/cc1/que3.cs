using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class que3

    {
        static void Main()
        {
            int[] input = { 1, 2, 3 };
            Console.WriteLine("Largest number among{0}, {1},{2} is:{3}", input[0], input[1], input[2], FindLargest(input));
            Console.Read();
        }

        static int
            FindLargest(int[] numbers)
        {
            int max = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;

        }
    }
}
