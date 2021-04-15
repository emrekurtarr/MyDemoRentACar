using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();
        Car GetByID(int id);
        List<Car> GetCarsByColorId(int colorid);
        List<Car> GetCarsByBrandId(int brandid);


    }
}
