using AutoMapper;
using Bl;
using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class NewsController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ISuccessStoriesService _successStoriesService;
        public NewsController(IBlogService blogService, ISuccessStoriesService successStoriesService)
        {
            _blogService = blogService;
            _successStoriesService = successStoriesService;
        }
        public IActionResult Blog()
        {
            return View(_blogService.GetAllBlogs());
        }
        public IActionResult SuccessStories()
        {
            return View(_successStoriesService.GetAllSuccessStories());
        }
    }
}
