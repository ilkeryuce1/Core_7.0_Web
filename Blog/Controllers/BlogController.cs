using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepos());
        public IActionResult Index()
        {
            var values = bm.GetListWithCategory();
            return View(values);
        }
        public IActionResult  BlogReadAll(int id)
        {
            var values = bm.GetBlogByID(id);
            return View (values);
        }
    }
}
