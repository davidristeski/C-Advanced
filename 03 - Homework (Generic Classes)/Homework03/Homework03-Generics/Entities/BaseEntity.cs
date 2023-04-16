using Homework03_Generics.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_Generics.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int MaxSpeed { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }

        public abstract void Drive(string destinationName);

    }
}
