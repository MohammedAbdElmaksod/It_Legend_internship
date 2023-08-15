using Bl;
using cloudscribe.Pagination.Models;
using Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class CandidateController : Controller
    {
        private readonly IService<Candidates> _candidate;
        private readonly IService<Categories> _category;

        public CandidateController(IService<Candidates> candidate, IService<Categories> category)
        {
            _candidate = candidate;
            _category = category;
        }

        public IActionResult Candidates(int pageNumber = 1, int pageSize = 1)
        {
            var result = new PagedResult<Candidates>()
            {
                Data = _candidate.GetAll(pageNumber, pageSize),
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = _candidate.totalCount()
            };
            return View(result);
        }
        [Authorize]
        public IActionResult CandidateProfile(string id)
        {
            var model = _candidate.GetAll().FirstOrDefault(u => u.userId == id);
            var category = _category.GetById((int)model.categoryId);
            model.Categories = category;
            return View(model);
        }
        [Authorize]
        public IActionResult CandidateProfileDashboard(int id)
        {
            return View(_candidate.GetById(id));
        }
        [Authorize]
        public IActionResult CandidateDashboard()
        {
            return View();
        }
        [Authorize]
        public IActionResult CandidateApplicants()
        {
            return View();
        }
        [Authorize]
        public IActionResult CandidateShortlist()
        {
            return View();
        }
        [Authorize]
        public IActionResult CandidateAlerts()
        {
            return View();
        }
    }
}
