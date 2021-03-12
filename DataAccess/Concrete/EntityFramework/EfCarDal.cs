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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from car in filter is null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join co in context.Colors
                             on car.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = b.Id,                                 
                                 BrandName = b.BrandName,
                                 CarName = car.ModelName,
                                 ColorId = co.Id,
                                 ColorName = co.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear


                             };
                return result.ToList();

            }
        }
    }
}
