using Business.Abstract;
using Core.Utilities;
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

        public IResult Add(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            if( car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(car.Description + " başarıyla eklendi");
            }
            else
            {
                //Console.WriteLine("Araba fiyatı 0'dan büyük ve modeli min 2 karakter uzunluğunda olmalıdır");
                return new ErrorResult("Araba fiyatı 0'dan büyük ve modeli min 2 karakter uzunluğunda olmalıdır !");
            }
        }

        public IResult Delete(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            _carDal.Delete(car);
            return new SuccessResult(car.Description + " başarıyla silindi."); 
        }

        public IResult Update(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            _carDal.Update(car);
            return new SuccessResult(car.Description + " başarıyla güncellendi.");
        }

        public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(filter));
        }

        public IDataResult<Car> Get(Expression<Func<Car, bool>> filter)
        {
            return new SuccessDataResult<Car>(_carDal.Get(filter));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByBrandId(brandid));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetCarsByColorId(colorid));
        }

        

        public IDataResult<List<CarDetails>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetails>>(_carDal.GetCarsDetails());
        }
    }
}
