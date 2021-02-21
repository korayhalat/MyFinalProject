using Business.Concrete;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManaeger productManaeger = new ProductManaeger(new InMemoryProductDal()); //IProductDal interface i new leyemediğimiz için onun referansını tutan InMemoryProductDal ı new liyoruz.

            foreach (var product in productManaeger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
