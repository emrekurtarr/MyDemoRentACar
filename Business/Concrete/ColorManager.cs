using Business.Abstract;
using Core.Utilities;
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

        public IResult Add(Color color)
        {
            _colorDAL.Add(color);
            return new SuccessResult(color.Name + " başarıyla eklendi.");
        }

        public IResult Delete(Color color)
        {
            _colorDAL.Delete(color);
            return new SuccessResult(color.Name + " başarıyla silindi.");
        }

        public IResult Update(Color color)
        {
            _colorDAL.Update(color);
            return new SuccessResult(color.Name + " başarıyla güncellendi.");
        }

        public IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return new SuccessDataResult<List<Color>>(_colorDAL.GetAll(filter));
        }

        public IDataResult<Color> Get(Expression<Func<Color, bool>> filter)
        {
            return new SuccessDataResult<Color>(_colorDAL.Get(filter));
        }

        
    }
}
