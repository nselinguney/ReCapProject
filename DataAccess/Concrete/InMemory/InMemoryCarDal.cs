using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal ()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=2, DailyPrice=545.92m, ModelYear="2010", Description="Renault Clio, Dizel/Benzin, Manuel"},
                new Car{ Id=2, BrandId=3, ColorId=5, DailyPrice=621.63m, ModelYear="2018", Description="Fiat Egea, Dizel/Benzin, Manuel"},
                new Car{ Id=3, BrandId=1, ColorId=7, DailyPrice=450.77m, ModelYear="2015", Description="Renaul Clio AT, Dizel/Benzin, Otomatik"},
                new Car{ Id=4, BrandId=4, ColorId=6, DailyPrice=745.13m, ModelYear="2019", Description="Ford Kuga, Dizel/Benzin, Otomatik"},
                new Car{ Id=5, BrandId=2, ColorId=10, DailyPrice=985.63m, ModelYear="2000", Description="BMW 2 Serisi, Dizel/Benzin, Otomatik"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();

            //where koşulu içindeki şartları uyan bütün elemanları yeni bir listeye dönüştürüp, onu döndürür.
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
