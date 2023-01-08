using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepos());



        public IActionResult Index()
        {
            var values=cm.GetAllCategories();
            return View(values);
        }
    }
}
