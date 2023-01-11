using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents.Comments
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepos());
		public IViewComponentResult Invoke(int id)
		{
			//gelecek ıdyı buraya tasımak ıcın blogreadall kısmından vıewbag ıle 
	
			var values = cm.GetCommentList(id);
			ViewBag.ilkyorum = values;
			return View(values);
		}
	}
}
