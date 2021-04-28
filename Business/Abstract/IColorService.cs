using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
        Color Get(Expression<Func<Color, bool>> filter);
    }
}
