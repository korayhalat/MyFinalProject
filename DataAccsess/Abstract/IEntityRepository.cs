using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface IEntityRepository<T>   //Entitis altındaki ürünleri iç içe kullanmak için Generics ten faydalanıyoruz.
    {   //Expression : Metodla listeden getirmek istediğimiz ürünleri filtreliyebilmemizi sağlıyo.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Tüm datayla ilgili,filter=null olursa filtre kullanmayabilirsin demek.
        T Get(Expression<Func<T, bool>> filter);//Tek bir data için.Burda filtre zorunlu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
