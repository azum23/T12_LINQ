using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_linq_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] current = { "Arzamas", "New York", "Moscow", "London", "Saint-P" };

            var query = from cities in current
                        where cities.Contains(" ") || cities.Contains("-")
                        orderby cities
                        select cities;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            // выбор через делегаты

            var query2 = current.Where(city => city.Contains(" ") || city.Contains('-')).OrderBy(city => city).Select(city => city);

            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
