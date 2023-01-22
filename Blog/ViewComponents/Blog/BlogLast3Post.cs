using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.ViewComponents.Blog
{
	public class BlogLast3Post : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepos());
		public IViewComponentResult Invoke()
		{
			var value = bm.GetLast3Blog();
			return View(value);
		}
	}
}
