using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var rentedCarList = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var car in rentedCarList)
            {
                if (car.ReturnDate == null)
                {
                    return new ErrorResult(Messages.NoRental);
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetCarById(int carId)
        {
            return new SuccessDataResult<List<Rental>>
                (_rentalDal.GetAll(rb => rb.CarId == carId));
        }

        public IDataResult<List<Rental>> GetCustomerById(int customerId)
        {
            return new SuccessDataResult<List<Rental>>
                (_rentalDal.GetAll(rci => rci.CustomerId == customerId));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
