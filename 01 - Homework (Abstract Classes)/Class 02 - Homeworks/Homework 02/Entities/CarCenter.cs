using Homework_02.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle checked");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle fixed");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Vehicle reservoir is filled");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"The car is clear");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"The trailer is clear");
        }
    }
}
