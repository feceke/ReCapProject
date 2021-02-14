﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2 || car.DailyPrice == 0)
            {
                Console.WriteLine("Araç ismi 2 karakterden fazla olmalı, fiyat sıfır olamaz");
            }
            else
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
