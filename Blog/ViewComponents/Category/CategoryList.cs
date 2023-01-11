using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Blog.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager( new EfCategoryRepos());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetAllCategories();
			return View(values);
		}
	}
}
