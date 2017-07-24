using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_LINQ_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 1, 2, 4, 5, 6, 76, 4, 3, 4, 55, 12, 5, 4, 8, 44, 4, 3 };
            int[] query = ((from i in first
                           where i % 2 == 0
                           select i).ToArray());

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
