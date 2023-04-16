using Homework_02.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02.Entities
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Filling fuel");
        }
    }
}
