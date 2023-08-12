using Bl;
using Bl.Data;
using Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class CandidateController :Controller
    {
        private readonly IService<Candidates> _candidate;
        private readonly IService<Categories> _category;

        public CandidateController(IService<Candidates> candidate, IService<Categories> category)
        {
            _candidate = candidate;
            _category = category;
        }

        public IActionResult Candidates()
        {
            return View(_candidate.GetAll());
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
