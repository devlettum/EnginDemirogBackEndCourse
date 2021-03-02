using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new() //Generict Constraint
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext()) //performans açısından using kullanıyoruz. //using bittiği an GarbageCollector devreye girer.
            {
                var addedEntity = context.Entry(entity); //veri kaynağına entity'i ekle(referansı yakala)
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //performans açısından using kullanıyoruz. //using bittiği an GarbageCollector devreye girer.
            {
                var deletedEntity = context.Entry(entity); //veri kaynağına entity'i ekle(referansı yakala)
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //performans açısından using kullanıyoruz. //using bittiği an GarbageCollector devreye girer.
            {
                var updatedEntity = context.Entry(entity); //veri kaynağına entity'i ekle(referansı yakala)
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
