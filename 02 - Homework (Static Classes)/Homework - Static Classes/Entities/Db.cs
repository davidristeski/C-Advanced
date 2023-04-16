using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___Static_Classes.Entities
{
    static class Db
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        static Db()
        {
            Vehicles = new List<Vehicle>()
        {
            new Car
            {
                Id = 1,
                Type = "Mercedes",
                YearOfProduction = 2019,
                BatchNumber = 12345,
                FuelTank = 50,
                ProducedInCountries = new List<string> { "USA", "Japan" }
            },
            new Bike
            {
                Id = 2,
                Type = "Cube",
                YearOfProduction = 2020,
                BatchNumber = 67890,
                Color = "Red"
            },
            new Vehicle
            {
                Id = 3,
                Type = "Car",
                YearOfProduction = 2018,
                BatchNumber = 54321
            }
            };

    }
    }
}
