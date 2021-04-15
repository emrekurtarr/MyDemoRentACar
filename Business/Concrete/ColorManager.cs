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
        private IColorDal _colorDAL;

        public ColorManager(IColorDal colorDAL)
        {
            _colorDAL = colorDAL;
        }

        public void Add(Color color)
        {
            _colorDAL.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDAL.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDAL.GetAll();
        }

        public Color GetByID(int id)
        {
            return _colorDAL.GetByID(id);
        }

        public void Update(Color color)
        {
            _colorDAL.Update(color);
        }
    }
}
