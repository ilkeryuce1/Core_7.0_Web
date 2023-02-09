using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	[AllowAnonymous]
    public class WriterController : Controller
	{

      

        public IActionResult Index()
		{
			return View();
		}
	
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
		[AllowAnonymous]
		public PartialViewResult WriterNavBarPartial()
		{
			return PartialView();
		}
	}
}
