using Homework_02.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing the {car}");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing the {truck}");
        }
    }
}
