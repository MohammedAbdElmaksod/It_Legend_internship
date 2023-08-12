using Bl;
using Bl.Data;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class EmployeeController :Controller
    {
        private readonly IEployeeService _employee;

        public EmployeeController(IEployeeService employee, ApplicationDbContext context)
        {
            _employee = employee;
        }

        public IActionResult Employers()
        {
           return View(_employee.GetAllEmployees());
        }
        public IActionResult EmployerDescrioption(int id)
        {
            return View(_employee.GetEmployeeById(id));
        }
    }
}
