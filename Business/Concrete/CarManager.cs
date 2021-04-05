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

            _carDal.Add(car);
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

        public Car GetByID(Car car)
        {
            return _carDal.GetByID(car);
        }

        public void Update(Car car)
        {
            //İş parçacığı kodları
            //If-else durumları burada yazılır

            _carDal.Update(car);
        }
    }
}
