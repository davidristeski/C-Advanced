using Homework_01.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01.Entities
{
    public class Cat : Animal, ICat
    {
        public void Eat(string food)
        {
            Console.WriteLine($"The cat {Name}, wants to eat {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This cat's name is {Name} and has {Color} color");
        }
    }
}
