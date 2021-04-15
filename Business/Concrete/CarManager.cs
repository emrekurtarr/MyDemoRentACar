using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetByID(int id)
        {
            return _carDal.GetByID(id);
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
    }
}
