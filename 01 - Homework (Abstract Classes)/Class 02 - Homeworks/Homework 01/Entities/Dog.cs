using Homework_01.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01.Entities
{
    public class Dog : Animal, IDog
    {
        public string Type { get; set; } = string.Empty;

        public void Bark()
        {
            Console.WriteLine($"The dog {Name}, started to bark");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This dog's name is {Name} and has {Color} color");
        }
    }
}
