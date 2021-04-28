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
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll(Expression<Func<Car,bool>> filter = null);
        Car Get(Expression<Func<Car, bool>> filter);
        List<Car> GetCarsByColorId(int colorid);
        List<Car> GetCarsByBrandId(int brandid);
        List<CarDetails> GetCarsDetails();



    }
}
