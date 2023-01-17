using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
