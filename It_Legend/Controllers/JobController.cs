using Bl;
using Domains;
using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cloudscribe.Pagination.Models;

namespace It_Legend.Controllers
{
    public class JobController : Controller
    {
        private readonly IService<Jobs> _jobService;
        private readonly IMapper _mapper;

        public JobController(IService<Jobs> jobService, IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }

        public IActionResult Jobs(int pageNumber = 1, int pageSize = 1)
        {
            var result = new PagedResult<Jobs>
            {
                Data = _jobService.GetAll(pageNumber, pageSize),
                PageSize = pageSize,
                PageNumber=pageNumber,
                TotalItems = _jobService.totalCount()
            };
            return View(result);
        }
        public IActionResult JobPackages()
        {
            return View();
        }
        public IActionResult JobDescription(int id)
        {
            var job = _jobService.GetById(id);
            var related = _mapper.Map<JobsWithRlated>(job);
            related.relatedJobs = _jobService.GetRelatedJobs((int)job.KindId);
            return View(related);
        }
        public IActionResult JobSubscribe()
        {
            return View();
        }
    }
}
