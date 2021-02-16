using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
       
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Deleted");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int BrandId)
        {
            return _brandDal.Get(b => b.BrandId == BrandId);
        }

        public void Add(Brand brand)
        {
            Console.WriteLine("Added");
        }

        public void Update(Brand brand)
        {
            Console.WriteLine("Updated");
        }
    }
}
