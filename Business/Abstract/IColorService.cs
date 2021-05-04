using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll(Expression<Func<Color, bool>> filter = null);
        IDataResult<Color> Get(Expression<Func<Color, bool>> filter);
    }
}
