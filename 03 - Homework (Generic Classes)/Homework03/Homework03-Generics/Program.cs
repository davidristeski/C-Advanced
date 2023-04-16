// Homework 03 - Generic classes

using Homework03_Generics.Entities;
using Homework03_Generics.Entities.Enums;
using Homework03_Generics.Entities.Helper;

AmericanCar ford = new AmericanCar()
{
    Id = 1,
    Brand = "Mustang",
    Model = "Sedan",
    MaxSpeed = 240,
    HorsePower = 180,
    FuelType = FuelType.Petrol
};

JapaneseCar toyota = new JapaneseCar()
{
    Id = 2,
    Brand = "Yaris",
    Model = "Hatchback",
    MaxSpeed = 190,
    HorsePower = 115,
    FuelType = FuelType.Diesel
};

GenericDb<JapaneseCar>.InsertCar(toyota);
GenericDb<AmericanCar>.InsertCar(ford);

GenericDb<JapaneseCar>.GetById(ford.Id);
GenericDb<JapaneseCar>.GetById(toyota.Id);

GenericDb<JapaneseCar>.PrintAllCars();

string newText = toyota.Brand;

newText.ColorText(ConsoleColor.Red);

GenericDb<BaseEntity>.PrintAllCars();



