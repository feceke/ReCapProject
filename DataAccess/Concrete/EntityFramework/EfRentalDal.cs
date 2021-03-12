using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto>GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ren in  context.Rentals
                             join c in context.Cars
                             on ren.CarId equals c.Id
                             join cu in context.Customers
                             on ren.CustomerId equals cu.Id
                             join us in context.Users
                             on cu.UserId equals us.Id                             
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 Id = ren.Id,
                                 BrandName = b.BrandName,
                                 CarName = c.ModelName,
                                 CompanyName = cu.CompanyName,
                                 UserName = us.FirstName+" "+us.LastName,
                                 CarId = c.Id,
                                 RentDate = ren.RentDate,
                                 ReturnDate = ren.ReturnDate,

                             };
                return result.ToList();

            }
        }
    }
}
