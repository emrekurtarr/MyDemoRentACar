using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ID=1,BrandId=1,ColorId=1,DailyPrice=1000,Description="Test Arabası1",ModelYear=1995},
                new Car{ID=2,BrandId=1,ColorId=3,DailyPrice=500,Description="Test Arabası2",ModelYear=2000},
                new Car{ID=3,BrandId=2,ColorId=4,DailyPrice=800,Description="Test Arabası3",ModelYear=1990},
                new Car{ID=4,BrandId=2,ColorId=2,DailyPrice=750,Description="Test Arabası4",ModelYear=2010},
                new Car{ID=5,BrandId=3,ColorId=5,DailyPrice=300,Description="Test Arabası5",ModelYear=2013},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            //           WITHOUT LINQ

            //Car deletedToCar = null;

            //foreach (var item in _cars)
            //{
            //    if (item.ID == car.ID)
            //    {
            //        deletedToCar = item;
            //    }
            //}
            //_cars.Remove(deletedToCar);

            //         WITH LINQ 

            Car deletedToCar = _cars.Where(c => c.ID == car.ID).SingleOrDefault();
            _cars.Remove(deletedToCar);


        }
        public void Update(Car car)
        {
            // WITHOUT LINQ

            //foreach (var item in _cars)
            //{
            //    if (item.ID == car.ID)
            //    {
            //        item.BrandID = car.BrandID;
            //        item.ColorID = car.ColorID;
            //        item.DailyPrice = car.DailyPrice;
            //        item.Description = car.Description;
            //        item.ModelYear = car.ModelYear;
            //    }
            //}

            // WITH LINQ

            Car UpdatedToCar = _cars.Where(c => c.ID == car.ID).SingleOrDefault();

            UpdatedToCar.BrandId = car.BrandId;
            UpdatedToCar.ColorId = car.ColorId;
            UpdatedToCar.DailyPrice = car.DailyPrice;
            UpdatedToCar.Description = car.Description;
            UpdatedToCar.ModelYear = car.ModelYear;

        }
        public List<Car> GetCarsByColorId(int colorid)
        {
            return _cars.Where(c => c.ColorId == colorid).ToList();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _cars.Where(c => c.BrandId == brandid).ToList();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetails> GetCarsDetails()
        {
            throw new NotImplementedException();
        }
    }
}
