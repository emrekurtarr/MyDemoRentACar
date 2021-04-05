using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{ID=1,BrandID=1,ColorID=1,DailyPrice=1000,Description="Test Arabası1",ModelYear=1995},
                new Car{ID=2,BrandID=1,ColorID=3,DailyPrice=500,Description="Test Arabası2",ModelYear=2000},
                new Car{ID=3,BrandID=2,ColorID=4,DailyPrice=800,Description="Test Arabası3",ModelYear=1990},
                new Car{ID=4,BrandID=2,ColorID=2,DailyPrice=750,Description="Test Arabası4",ModelYear=2010},
                new Car{ID=5,BrandID=3,ColorID=5,DailyPrice=300,Description="Test Arabası5",ModelYear=2013},

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

            UpdatedToCar.BrandID = car.BrandID;
            UpdatedToCar.ColorID = car.ColorID;
            UpdatedToCar.DailyPrice = car.DailyPrice;
            UpdatedToCar.Description = car.Description;
            UpdatedToCar.ModelYear = car.ModelYear;

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetByID(Car car)
        {
            return _cars.Where(c => c.ID == car.ID).SingleOrDefault();
        }


    }
}
