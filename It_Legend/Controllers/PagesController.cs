using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult OurIndustries()
        {
            return View();
        }
    }
}
