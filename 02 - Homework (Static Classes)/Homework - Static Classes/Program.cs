// Homework 02 - Static Classes

using Homework___Static_Classes.Entities;
using System.Net.Http.Headers;

foreach (var vehicle in Db.Vehicles)
{
    vehicle.PrintVehicle();
}

Car bmw = new Car() {Id = 25, YearOfProduction = 1956, Type = "Car"};

Validator.Validate(bmw);

Bike trinx = new Bike() { YearOfProduction = 2023 };

Validator.Validate(trinx);
