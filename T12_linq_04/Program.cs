using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_linq_04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myCars = new ArrayList()
            {
                new Car {Brand="BMW", Model ="X5", Color=Color.Black, Speed = 250 },
                new Car {Brand="Mercedes", Model ="E", Color=Color.Blue, Speed = 230 },
                new Car {Brand="Kia", Model ="Ceed", Color=Color.Green, Speed = 190 },
                new Car {Brand="BMW", Model ="5", Color=Color.Red, Speed = 240 },
                new Car {Brand="Kia", Model ="Cerato", Color=Color.Black, Speed = 200 },
            };

            var myCarsEnum = myCars.OfType<Car> ();

            var fastCar = from c in myCarsEnum
                          where c.Speed > 200
                          orderby c.Brand descending
                          select new
                          {
                              c.Brand,
                              c.Model
                          };


            foreach (var c in fastCar)
            {
                Console.WriteLine(c.Brand + " " + c.Model);
            }

            Console.ReadLine();
        }
    }
}

