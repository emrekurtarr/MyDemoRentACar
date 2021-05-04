using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll(Expression<Func<Car,bool>> filter = null);
        IDataResult<Car> Get(Expression<Func<Car, bool>> filter);
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<Car>> GetCarsByBrandId(int brandid);
        IDataResult<List<CarDetails>> GetCarsDetails();



    }
}
