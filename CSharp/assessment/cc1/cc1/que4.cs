
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class que4
    {
        static void Main()
        {
            Console.WriteLine("Enter a num ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + "*" + i+"=" +a*i);
            }
            Console.Read();

        }
    }
}
