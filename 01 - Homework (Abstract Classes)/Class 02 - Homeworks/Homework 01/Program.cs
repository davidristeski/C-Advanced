// Homework 01 - Abstract classes and interfaces

using Homework_01.Entities;

Cat tom = new Cat()
{
    Name = "Tom",
    Color = "grey"

};

Dog spike = new Dog()
{
    Name = "Spike",
    Color = "brown"
};

tom.Eat("fish");
tom.PrintAnimal();
spike.PrintAnimal();
