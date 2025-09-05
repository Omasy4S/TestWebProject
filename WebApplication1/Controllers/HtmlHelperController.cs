using Microsoft.AspNetCore.Mvc;

namespace TestWebProject.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
