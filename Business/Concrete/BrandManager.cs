using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService

    {
        IBrandDal _branDal;

        public BrandManager(IBrandDal branDal)
        {
            _branDal = branDal;
        }

        public IResult Add(Brand brand)
        {
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetBrandsByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_branDal.GetAll(bra => bra.Id == id));
        }

        public IDataResult<List<Brand>> GetBrandsByBrandNAme(string BrandName)
        {
            return new SuccessDataResult<List<Brand>>(_branDal.GetAll(bn => bn.BrandName == BrandName));
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
