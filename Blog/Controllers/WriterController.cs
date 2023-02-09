using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{

    public class WriterController : Controller
	{
		[AllowAnonymous]
	
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
