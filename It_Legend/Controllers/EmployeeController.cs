using AutoMapper;
using Bl;
using Bl.Data;
using cloudscribe.Pagination.Models;
using Domains;
using Domains.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEployeeService _employee;
        private readonly IMapper _mapper;
        private readonly IService<Categories> _category;

        public EmployeeController(IEployeeService employee, IMapper mapper, IService<Categories> category)
        {
            _employee = employee;
            _mapper = mapper;
            _category = category;
        }

        public IActionResult Employers(int pageNumber = 1, int pageSize = 1)
        {
            var result = new PagedResult<Employees>
            {
                Data = _employee.GetAll(pageNumber, pageSize),
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = _employee.totalCount()
            };
            return View(result);
        }
        public IActionResult EmployerDescrioption(string id)
        {
            var model = _employee.GetAllEmployees().FirstOrDefault(u => u.userId == id);
            return View(model);
        }
        [Authorize(Roles = "Employeer")]
        public IActionResult EmployerProfileDashboard(string id)
        {
            var emp = _employee.GetAllEmployees().FirstOrDefault(u => u.userId == id);
            var empVm = _mapper.Map<EmployeeVm>(emp);
            empVm.lstCategories = _category.GetAll();
            return View(empVm);
        }
        [HttpPost]
        public async Task<IActionResult> EmployerProfileDashboard(EmployeeVm employee ,int id, IFormFile file)
        {
            if(id>0)
                employee.Id = id;
            
            if (!ModelState.IsValid)
            {
                employee.lstCategories = _category.GetAll();
                return View(employee);
            }
            if (file is not null)
            {
                string ImageName = Guid.NewGuid().ToString() + ".jpg";
                var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads\Images", ImageName);
                using (var stream = System.IO.File.Create(filePaths))
                {
                    await file.CopyToAsync(stream);
                }
                employee.logoUrl = ImageName;
            }

            var emp =_mapper.Map<Employees>(employee);
            await _employee.EditEmployee(emp);
            return RedirectToAction(nameof(EmployerDescrioption));
        }
    }
}
