using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Static_Classes.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public void PrintVehicle()
        {
            Console.WriteLine($"Vehicle ID: {Id}");
            Console.WriteLine($"Vehicle Type: {Type}");
            Console.WriteLine($"Vehicle year of production: {YearOfProduction}");
        }
    }
}
