using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, MyDbContext>, ICarDal
    {

        public List<Car> GetCarsByBrandId(int brandid)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Cars.Where(c => c.BrandId == brandid).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Cars.Where(c => c.ColorId == colorid).ToList();
            }
        }

        public List<CarDetails> GetCarsDetails()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                var result = from car in myDbContext.Cars
                             join b in myDbContext.Brands on car.BrandId equals b.BrandId
                             join color in myDbContext.Colors on car.ColorId equals color.ColorId
                             select new CarDetails {
                                 CarName = car.Description, BrandName = b.Name, ColorName = color.Name, DailyPrice = car.DailyPrice 
                             };

                return result.ToList();
                             
            }
        }

    }
}
