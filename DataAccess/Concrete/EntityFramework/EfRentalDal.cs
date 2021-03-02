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
        public List<RentalDetailDto>GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ren in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on ren.CarId equals c.Id
                             join cu in context.Customers
                             on ren.CustomerId equals cu.Id
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = ren.Id,
                                 CarName = c.Name,
                                 CustomerName = cu.CompanyName,
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
