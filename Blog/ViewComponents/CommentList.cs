using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.ViewComponents
{
	public class CommentList : ViewComponent
	{
		//cagır anlamına elen ınvoke 
		public IViewComponentResult Invoke()
		{
			return View();
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					UserName="ilker"
				},
				new UserComment
				{
					ID= 2,
					UserName="Ali"
				}

			};
		}
	}
}
