using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Static_Classes.Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> ProducedInCountries { get; set; } = new List<string>();

        public void PrintVehicle()
        {
            Console.WriteLine($"Vehicle type: {Type}");
            Console.WriteLine($"Produced in {ProducedInCountries}");
        }
    }
}
