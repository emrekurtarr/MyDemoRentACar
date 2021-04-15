using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                myDbContext.Add(entity);
                myDbContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Brand deletedBrand = myDbContext.Brand.FirstOrDefault(b => b.BrandId == entity.BrandId);

                if (deletedBrand != null)
                {
                    myDbContext.Remove(deletedBrand);
                    myDbContext.SaveChanges();
                }
            }
        }

        public List<Brand> GetAll()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Brand.ToList();
            }
        }

        public Brand GetByID(int id)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Brand brand = myDbContext.Brand.FirstOrDefault(b => b.BrandId == id);
                return brand;
            }
        }

        public void Update(Brand entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Brand updatedBrand = myDbContext.Brand.FirstOrDefault(b => b.BrandId == entity.BrandId);

                if (updatedBrand != null)
                {
                    updatedBrand = entity;
                    myDbContext.SaveChanges();
                }
            }
        }
    }
}
