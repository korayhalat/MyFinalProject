using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{       //T yi sınırlama ya generic constraint denir.Yani mevcut veri tabanı nesneleri hangileriyse onları sınırlamamız gerekir.
        //IEntity : IEntity olabilir yada IEntity implemente eden bir nesne olabilir anlamına geliyo.
        //yani böylece parametrelerimiz sınırlamış olduk.
    public interface IEntityRepository<T> where T:class,IEntity   //Burda yazdığımız class :Referans tip olabilir demek anlamına geliyo!!!,Entitis altındaki ürünleri iç içe kullanmak için Generics ten faydalanıyoruz.
    {                                                                       //Expression : Metodla listeden getirmek istediğimiz ürünleri filtreliyebilmemizi sağlıyo.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);               //Tüm datayla ilgili,filter=null olursa filtre kullanmayabilirsin demek.
        T Get(Expression<Func<T, bool>> filter);                            //Tek bir data için.Burda filtre zorunlu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
