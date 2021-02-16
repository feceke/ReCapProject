using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
             new Car{ Id=1, BrandId=1, ModelName="Accent", ModelYear="2012", ColorId=1, DailyPrice=150, Description="Benzin + Lpg" },
             new Car{ Id=2, BrandId=1, ModelName="Symbol", ModelYear="2010", ColorId=2, DailyPrice=140, Description="Dizel" },
             new Car{ Id=3, BrandId=2, ModelName="Transporter", ModelYear="2000", ColorId=3, DailyPrice=500, Description="Dizel" },
             new Car{ Id=4, BrandId=2, ModelName="A6", ModelYear="2004", ColorId=4, DailyPrice=350, Description="Benzin + Lpg" },

        };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
                
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}