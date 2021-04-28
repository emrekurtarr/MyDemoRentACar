using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colorDAL.GetAll(filter);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return _colorDAL.Get(filter);
        }

        public void Update(Color color)
        {
            _colorDAL.Update(color);
        }
    }
}
