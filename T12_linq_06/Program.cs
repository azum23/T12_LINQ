using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_linq_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 13.34, 35.4, 3.4, 43 };
            
            double sum = (from i in array
                          select i).Sum();
            Console.WriteLine(sum);

            double max = (from i in array
                          select i).Max();
            Console.WriteLine(max);

            double min = (from i in array
                          select i).Min();
            Console.WriteLine(min);

            double average = (from i in array
                          select i).Average();
            Console.WriteLine(average);


            Console.ReadKey();

        }
    }
}
