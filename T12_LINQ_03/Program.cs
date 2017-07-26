using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_LINQ_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car {Brand="BMW", Model ="X5", Color=Color.Black, Speed = 250 },
                new Car {Brand="Mercedes", Model ="E", Color=Color.Blue, Speed = 230 },
                new Car {Brand="Kia", Model ="Ceed", Color=Color.Green, Speed = 190 },
                new Car {Brand="BMW", Model ="5", Color=Color.Red, Speed = 240 },
                new Car {Brand="Kia", Model ="Cerato", Color=Color.Black, Speed = 200 },
            };

            var fastCar = from c in myCars
                          where c.Speed > 200
                          select c;

            foreach (var c in fastCar)
            {
                Console.WriteLine(c.Brand + " " + c.Model);
            }

            Console.ReadLine();
        }
    }
}
