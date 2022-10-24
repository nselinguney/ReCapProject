using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car { BrandId=1, ColorId=2, DailyPrice=1591.05M, Description="Mercedes C Serisi", ModelYear="2019"});
            carManager.Add(new Car { BrandId=4, ColorId=3, DailyPrice=1647.8M, Description = "Volvo XC40", ModelYear = "2020" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
