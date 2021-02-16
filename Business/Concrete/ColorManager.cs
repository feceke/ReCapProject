using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService

    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            Console.WriteLine("Added");
        }

        public void Delete(Color color)
        {
            Console.WriteLine("Deleted");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int ColorId)
        {
            return _colorDal.Get(c => c.ColorId == ColorId);
        }

        public void Update(Color color)
        {
            Console.WriteLine("Updated");
        }
    }
}
