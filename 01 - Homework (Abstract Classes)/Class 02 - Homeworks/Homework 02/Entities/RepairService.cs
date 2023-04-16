using Homework_02.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Analazyng the vehivle for problems");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing the issues of the vehicle");
        }
    }
}
