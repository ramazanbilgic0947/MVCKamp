using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2_Data_Access_Layer.Abstract
{
  public  interface IRepository<T>
    {// crud operasyonlarını birer metod olarak tanımlıcaz buraya
         //Type Name();// Bir Tip ekleyip metodu kapatacağız
         List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List(Expression<Func<T,bool>> filter);
        //Bir sınıf oluşturup burdaki metodların görevlerini yazacağız o sınıfta
    }
}
