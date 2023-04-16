using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Static_Classes.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; } = string.Empty;

        public void PrintVehicle()
        {
            Console.WriteLine($"Vehicle year of production: {YearOfProduction}");
            Console.WriteLine($"Bike color: {Color}");
        }
    }
}
