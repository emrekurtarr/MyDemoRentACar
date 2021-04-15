using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : ICarDal
    {

        
        public void Add(Car entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                myDbContext.Add(entity);
                myDbContext.SaveChanges();
            }
        }



        public void Delete(Car entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Car deletedCar = myDbContext.Cars.FirstOrDefault(c => c.ID == entity.ID);

                if(deletedCar != null)
                {
                    myDbContext.Remove(deletedCar);
                    myDbContext.SaveChanges();
                }
            }
        }

        public List<Car> GetAll()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Cars.ToList();
            }
        }

        public Car GetByID(int id)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Car car = myDbContext.Cars.FirstOrDefault(c => c.ID == id);
                return car;
            }
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            using(MyDbContext myDbContext = new MyDbContext())
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

        public void Update(Car entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Car updatedCar = myDbContext.Cars.FirstOrDefault(c => c.ID == entity.ID);

                if(updatedCar != null)
                {
                    updatedCar = entity;
                    myDbContext.SaveChanges();
                }
            }
        }
    }
}
