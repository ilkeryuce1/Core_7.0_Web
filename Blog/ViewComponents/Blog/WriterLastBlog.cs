

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepos());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListWriter(1);
			return View(values);
		}
	}
}
