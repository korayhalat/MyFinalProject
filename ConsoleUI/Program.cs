﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManaeger productManaeger = new ProductManaeger(new EfProductDal()); //IProductDal interface i new leyemediğimiz için onun referansını tutan InMemoryProductDal ı new liyoruz.

            foreach (var product in productManaeger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
