using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            if( car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba fiyatı 0'dan büyük ve modeli min 2 karakter uzunluğunda olmalıdır");
            }

            
            
        }

        public void Delete(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            _carDal.Delete(car);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _carDal.Get(filter);
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetCarsByBrandId(brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetCarsByColorId(colorid);
        }

        public void Update(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            _carDal.Update(car);
        }

        public List<CarDetails> GetCarsDetails()
        {
            return _carDal.GetCarsDetails();
        }
    }
}
