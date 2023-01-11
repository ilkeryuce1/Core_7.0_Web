using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager vm = new WriterManager(new EfWriterRepos());
		public IActionResult Index()
		{
			return View();
			//Attribute Bir metota görev yuklemek amacıyla kullanılır[Key bunlara bır ornektır] Httpget ve post da bunlara ornektır
		}

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			writer.WriterStatus = true;
			writer.WriterAbout = "Test";
			vm.WriterAdd(writer);
			return RedirectToAction("Index","Blog");
		}
	
	}
}
