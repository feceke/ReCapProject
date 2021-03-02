using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);


        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetBrandsByBrandId(int id);
        IDataResult<List<Brand>> GetBrandsByBrandNAme(string BrandName);

    }
}