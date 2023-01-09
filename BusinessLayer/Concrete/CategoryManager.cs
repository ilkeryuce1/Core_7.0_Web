using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //busınnes katmanında abstract klasoru ıcınde yer alan interfaceler servis olarak adlandırılır.
    //busınnes katmanında concrete klasoru ıcınde yer alan sınıflar : Manager olarak adlandırılır.
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //Constractor metot olusturuyoruz
   

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            #region Yorum
            //if (category.CategoryName!=""&&category.CategoryDescription!=""&&category.CategoryName.Length>=5 &&category.CategoryStatus==true)
            //{
            //    categoryRepos.AddCategory(category);

            //}
            //else
            //{
            //    //Hata mesajını kurulan yapı fluent validiton
            //}

            #endregion

            _categoryDal.Insert(category);

        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            _categoryDal.Delete(category);

        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
