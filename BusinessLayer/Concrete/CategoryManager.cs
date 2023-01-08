using BusinessLayer.Abstract;
using DataAccessLayer.Repostories;
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
        //CategoryRepos categoryRepos = new CategoryRepos(); bunun yerıne ;
        GenericRepos<Category> _repos=new GenericRepos<Category>();
        public void AddCategory(Category category)
        {
            //if (category.CategoryName!=""&&category.CategoryDescription!=""&&category.CategoryName.Length>=5 &&category.CategoryStatus==true)
            //{
            //    categoryRepos.AddCategory(category);

            //}
            //else
            //{
            //    //Hata mesajını kurulan yapı fluent validiton
            //}


        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategory(Category category)
        {
            if (category.CategoryID != 0 && category.CategoryID != null)
            {
                _repos.Delete(category);
            }

        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
