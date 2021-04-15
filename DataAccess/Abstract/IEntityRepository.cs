using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new ()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
        List<T> GetAll();

    }
}
