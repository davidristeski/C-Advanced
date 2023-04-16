using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Static_Classes.Entities
{
    static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction == 0)
            {
                Console.WriteLine("Validation failed!");
            }
            else
            {
                Console.WriteLine("Validation passed!");
            }

        }
    }
}
