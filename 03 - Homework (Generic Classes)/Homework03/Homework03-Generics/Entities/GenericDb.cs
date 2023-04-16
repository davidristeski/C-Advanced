using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03_Generics.Entities
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db = new List<T>();
        public static void InsertCar(T item)
        {
            Db.Add(item);
            Console.WriteLine($"Added is a car, with id number: {item.Id} to the GenericDb.");
        }

        public static void GetById(int id)
        {
            foreach (T item in Db)
            {
                if (item.Id == id)
                {
                    Console.WriteLine($"ID:{item.Id} -- {item.Model}, {item.Brand}");
                }
                else { Console.WriteLine("Id does not match the stored cars.");
                }
            }
        }

        public static void PrintAllCars()
        {
            foreach (var T in Db)
            {
                Console.WriteLine($"Id: {T.Id}, Brand: {T.Brand}, Model: {T.Model}, MaxSpeed: {T.MaxSpeed}, HorsePower: {T.HorsePower}, FuelType: {T.FuelType}");
            }
        }
    }
}
