using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity item)
        {
            using(TContext context = new TContext())
            {
                context.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity item)
        {
            using (TContext context = new TContext())
            {
                TEntity deletedItem = context.Entry(item).Entity;
                context.Remove(item);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity item)
        {
            using (TContext context = new TContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
