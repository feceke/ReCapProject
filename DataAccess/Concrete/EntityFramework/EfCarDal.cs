using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join co in context.Colors
                             on car.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = b.Id,                                 
                                 BrandName = b.Name,
                                 CarName = car.Name,
                                 ColorId = co.Id,
                                 ColorName = co.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear


                             };
                return result.ToList();

            }
        }
    }
}
