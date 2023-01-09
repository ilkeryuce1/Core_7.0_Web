using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm =new  CommentManager(new EfCommentRepos());

	

		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();

		}
		public PartialViewResult CommentListByBlog(int id) 
		{
			var values = cm.GetCommentList(id);	
			return PartialView(values);
		}
	}
}
