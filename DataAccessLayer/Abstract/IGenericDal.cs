using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        //metot tanımlamayı kolaylastırır
        void Insert(T t);
        void Delete(T t);
        void Update (T t);
        List<T> GetAll();   
        T GetById(int id);//Id Parametresı alır 
    }
}
