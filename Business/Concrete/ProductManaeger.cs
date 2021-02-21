using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManaeger : IProductService  //Burda constructor yaptık.
    {
        IProductDal _iProductDal;

        public ProductManaeger(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();   
        }
    }
}
