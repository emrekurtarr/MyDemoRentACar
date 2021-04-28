using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDAL;

        public BrandManager(IBrandDal brandDAL)
        {
            _brandDAL = brandDAL;
        }

        public void Add(Brand brand)
        {
            _brandDAL.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDAL.Delete(brand);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brandDAL.GetAll(filter);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return _brandDAL.Get(filter);
        }

    

        public void Update(Brand brand)
        {
            _brandDAL.Update(brand);
        }
    }
}
