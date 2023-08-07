using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult SuccessStories()
        {
            return View();
        }
    }
}
