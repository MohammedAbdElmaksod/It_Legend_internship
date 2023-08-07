using Bl;
using Domains;
using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


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

        public IActionResult Jobs()
        {
            return View(_jobService.GetAll());
        }
        public IActionResult JobPackages()
        {
            return View();
        }
        public IActionResult JobDescription(int id)
        {
            var job = _jobService.GetById(id);
            var related = _mapper.Map <JobsWithRlated>(job);
            related.relatedJobs = _jobService.GetRelatedJobs((int)job.KindId);
            return View(related);
        }
        public IActionResult JobSubscribe()
        {
            return View();
        }
    }
}
