using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constraint --> generic kısıt
    //class -> referans tip
    //new ()--> newlenebilir olmalı.interface newlenemez.
    public interface IEntityRepository<T>where T:class,IEntity,new()//Ientity veya implementasyonları.
    {
        //Ayrı ayrı Category ve Product'a interface oluşturacağımıza T tipinde tek bir interface oluşturduk.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //null --> filter vermeyebilirsin.
        T Get(Expression<Func<T, bool>> filter); //filtre vermek zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
