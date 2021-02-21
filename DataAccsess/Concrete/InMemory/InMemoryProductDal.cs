using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory //Abstract altındaki IProductdal inreface nin Somut sayfasını InMemory dosyasının içinde
{                                       //InMemoryProductDal sınıfını oluşturuyoruz.
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;        //_product şeklinde yazığımız zaman,bu global anlamına geliyo.Metodların dışında,class ın içinde.
        public InMemoryProductDal()     //constructer oluşturduk.
        {
            _products = new List<Product> //Ürün listeliyoruz...
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UniPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UniPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UniPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UniPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=1,ProductName="Fare",UniPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {

            _products.Add(product);
        }

        public void Delete(Product product)     //Linq kullanmazsak silmek için kullanabileceğimiz yapı bu şekilde olur.
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    productToDelete = p;
            //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);  //Burda LINQ kullandık.
            //yukardaki Bu kod her p için p nin Id si ,benim gönderdiğim productId Listedeki productId ye eşitmi?Herbiri için dolaş demek.
            //SingleOrDefault bir tane arar.Genelde Id aramlarında kullanılır.
            _products.Remove(productToDelete);


        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product) //Güncelleme için de LINQ yapısını kulladık.
        {
            Product productToUpdate = productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UniPrice = product.UniPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {

        }
        public List<Product> Get(Expression<Func<Product, bool>> filter)
        {

        }

        Product IEntityRepository<Product>.Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
