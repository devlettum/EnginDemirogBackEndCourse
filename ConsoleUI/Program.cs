using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle --> yeni özellik eklenince mevcutta hiçbir koduna dokunamazsın.
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //DetailssTest();

        }

        //private static void DetailssTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    foreach (var product in productManager.GetProductDetails().Data)
        //    {
        //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        //    }
        //}

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var c in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(c.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetByUnitPrice(40,500);
        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}
