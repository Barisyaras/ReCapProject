using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1,BrandId=1,ColorId=3,DailyPrice=200000,Description="Opel",ModelYear="2021",},
                new Car{CarId=2,BrandId=2,ColorId=1,DailyPrice=350000,Description="Audi",ModelYear="2016",},
                new Car{CarId=3,BrandId=3,ColorId=2,DailyPrice=250000,Description="Ford",ModelYear="2018",},
                new Car{CarId=4,BrandId=4,ColorId=1,DailyPrice=400000,Description="Fiat",ModelYear="2023",},
                new Car{CarId=5,BrandId=1,ColorId=4,DailyPrice=125000,Description="Opel",ModelYear="2015",}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId ==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
