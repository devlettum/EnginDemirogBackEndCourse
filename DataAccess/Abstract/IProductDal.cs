using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Project Referance vermeyi unutma !!

        //Veritabanı Operasyonlarının imzası(IERpstry'e yolladık,düzenledik kodları :) )
        List<ProductDetailDto> GetProductDetails();

        
    }
}
