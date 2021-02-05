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
             new Car{ Id=1, BrandId=1, BrandName="Hyundai", ModelName="Accent", ModelYear="2012", DailyPrice=85000, Description="Ölücüler Aramasın" },
             new Car{ Id=2, BrandId=1, BrandName="Renault", ModelName="Symbol", ModelYear="2010", DailyPrice=65000, Description="Boya Takıntısı olan aramasın" },
             new Car{ Id=3, BrandId=2, BrandName="Volkswagen", ModelName="Transporter", ModelYear="2000", DailyPrice=80000, Description="Dosta gider" },
             new Car{ Id=4, BrandId=2, BrandName="Audi", ModelName="A6", ModelYear="2004", DailyPrice=100000, Description="10 numara araba" },

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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
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