using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Controllers
{
    [AllowAnonymous]
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
			WriterValidator vr = new WriterValidator();
			ValidationResult result = vr.Validate(writer);
			
			if (ModelState.IsValid)
			{
                writer.WriterStatus = true;
                writer.WriterAbout = "Test";
                vm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
			//ModelError geçip model tanımlıyoryuz 
		
		}
	
	}
}
