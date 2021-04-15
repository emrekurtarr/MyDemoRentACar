using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                myDbContext.Add(entity);
                myDbContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Color deletedColor = myDbContext.Colors.FirstOrDefault(c => c.ColorId == entity.ColorId);

                if (deletedColor != null)
                {
                    myDbContext.Remove(deletedColor);
                    myDbContext.SaveChanges();
                }
            }
        }

        public List<Color> GetAll()
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                return myDbContext.Colors.ToList();
            }
        }

        public Color GetByID(int id)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Color color= myDbContext.Colors.FirstOrDefault(c => c.ColorId == id);
                return color;
            }
        }

        public void Update(Color entity)
        {
            using (MyDbContext myDbContext = new MyDbContext())
            {
                Color updatedColor = myDbContext.Colors.FirstOrDefault(c => c.ColorId == entity.ColorId);

                if (updatedColor != null)
                {
                    updatedColor = entity;
                    myDbContext.SaveChanges();
                }
            }
        }
    }
}
