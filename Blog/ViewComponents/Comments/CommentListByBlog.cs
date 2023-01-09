using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents.Comments
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepos());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetCommentList(7);
			return View(values);
		}
	}
}
