using Bl;
using Domains;
using It_Legend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace It_Legend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Jobs> _jobService;

        public HomeController(IService<Jobs> jobService)
        {
            _jobService = jobService;
        }

        public IActionResult Index()
        {
            return View(_jobService.GetAll());
        }
       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}