using Bl;
using Bl.Data;
using Domains;
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
        public IActionResult CandidateProfile(int id)
        {
            var model = _candidate.GetById(id);
            var category = _category.GetById((int)model.categoryId);
            model.Categories = category;
            return View(model);
        }
        public IActionResult CandidateProfileDashboard(int id)
        {
            return View(_candidate.GetById(id));
        }
        public IActionResult CandidateDashboard()
        {
            return View();
        }
        public IActionResult CandidateApplicants()
        {
            return View();
        }
        public IActionResult CandidateShortlist()
        {
            return View();
        }
        public IActionResult CandidateAlerts()
        {
            return View();
        }
    }
}
