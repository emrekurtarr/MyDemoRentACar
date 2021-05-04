using Business.Abstract;
using Core.Utilities;
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

        public IResult Add(Brand brand)
        {
            _brandDAL.Add(brand);
            return new SuccessResult(brand.Name + " başarıyla eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandDAL.Delete(brand);
            return new SuccessResult(brand.Name + " başarıyla silindi");
        }

        public IResult Update(Brand brand)
        {
            _brandDAL.Update(brand);
            return new SuccessResult(brand.Name + " başarıyla güncellendi");
        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return new SuccessDataResult<List<Brand>>(_brandDAL.GetAll(filter));
        }

        public IDataResult<Brand> Get(Expression<Func<Brand, bool>> filter)
        {
            return new SuccessDataResult<Brand>(_brandDAL.Get(filter));
        }

    

        
    }
}
