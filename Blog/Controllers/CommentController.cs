using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
		[HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
			c.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			c.CommentStatus = true;
			c.BlogID = 2;
			cm.CommentAdd(c);
            return PartialView();

        }
        public PartialViewResult CommentListByBlog(int id) 
		{
			var values = cm.GetCommentList(id);	
			return PartialView(values);
		}
	}
}
