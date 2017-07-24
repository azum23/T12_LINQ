using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_LINQ_01
{
    class Program
    {
        static void Reflector(object result)
        {
            Console.WriteLine(result.GetType().Name);
            Console.WriteLine(result.GetType().Assembly.GetName().Name);
        }

        static void Query()
        {
            string[] cityes = { "New York", "Arzamas 16",
                "Saint-Petersburg", "Moscow",
                "Chelyabinsk23", "Ozersk" };

            IEnumerable<string> subset = from c in cityes
                                         where c.Contains("a")
                                         orderby c
                                         select c;
           
            foreach(var c in subset)
            {
                Console.WriteLine(c);
            }
            Reflector(subset);
        }

        static void Main(string[] args)
        {


            Query();

            Console.ReadKey();
        }
    }
}
