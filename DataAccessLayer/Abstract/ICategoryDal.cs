using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal :IGenericDal<Category>
    {
        ////üzzerinde çalıştığımız tabloyu ekledık 
        //List<Category> ListAllCategory();
        //void AddCategory(Category category);
        //void DeleteCategory(Category category);
        //void UpdateCategory(Category category);
        //Category GetById(int id);//Idye gore kategorı ıslemlerı ıcın metot




        //  :IGenericDal<Category> diyerek islemleri direkt olarak oradan cekebuluyoruz 
        //7/Böylece metotları tekrar tekrar yazmaktan kurtulduk ve genricten mıras aldık


    }
}
