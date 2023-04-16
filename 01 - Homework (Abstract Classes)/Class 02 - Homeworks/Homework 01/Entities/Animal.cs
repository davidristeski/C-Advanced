using Homework_01.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract void PrintAnimal();
 
        
    }
}
