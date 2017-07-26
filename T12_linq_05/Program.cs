using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_linq_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>() { "Audi", "Ford", "BMW" };
            List<string> myCars = new List<string>() { "Kia", "Audi", "Mercedes" };

            var carDiff = (from c in cars select c).Except(from c2 in myCars select c2);

            foreach (var item in carDiff)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string ('-',30));
            var carIntersect = (from c in cars select c).Intersect(from c2 in myCars select c2);

            foreach (var item in carIntersect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
            var carUnion = (from c in cars select c).Union(from c2 in myCars select c2);

            foreach (var item in carUnion)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
