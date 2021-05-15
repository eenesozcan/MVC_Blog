using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //Burası CRUD operasyonlarının gerçekleşeceği methotların tanımladığı yer

        List<T> List();

        void Insert(T p); //T sınıfından gelen bir p parametresi 

        T Get(Expression<Func<T, bool>> filter); // silme işlemleri için id'yi buldurma için kullanılacak

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter); //şartlı listleme
    }
}
