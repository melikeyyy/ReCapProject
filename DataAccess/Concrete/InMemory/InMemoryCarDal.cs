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
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=2,DailyPrice=100, ModelYear=1999,Description="Bmw"},

                new Car{Id=2, BrandId=1, ColorId=3,DailyPrice=150, ModelYear=1999,Description="Kia"},

                new Car{Id=3, BrandId=2, ColorId=1,DailyPrice=600, ModelYear=1999,Description="Porshe"},

                new Car{Id=4, BrandId=2, ColorId=2,DailyPrice=100, ModelYear=1999,Description="Ford"},

                new Car{Id=5, BrandId=3, ColorId=3,DailyPrice=60, ModelYear=1999,Description="Renault"}

            };



        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {

            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
