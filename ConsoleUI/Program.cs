using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var returnedCar in carManager.GetAll())
            {
                Console.WriteLine(returnedCar.Description);
            }

            Car car = new Car();
            car.Id = 10;
            car.BrandId = 11;
            car.ColorId = 3;
            car.ModelYear = "2015";
            car.Description = "Peugeot 5008, Dizel, Otomatik";

            carManager.Add(car);
            Console.WriteLine("Yeni bir araba eklendikten sonra--------------------------"); 
            foreach (var returnedCar in carManager.GetAll())
            {
                Console.WriteLine(returnedCar.Description);
            }

            Console.WriteLine("Bir araba silindikten sonra--------------------------"); 
            carManager.Delete(car);

            foreach (var returnedCar in carManager.GetAll())
            {
                Console.WriteLine(returnedCar.Description);
            }
        }
    }
}
