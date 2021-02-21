﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface ICategoryDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
