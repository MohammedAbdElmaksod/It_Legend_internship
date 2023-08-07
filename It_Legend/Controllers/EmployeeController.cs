using Bl;
using Microsoft.AspNetCore.Mvc;

namespace It_Legend.Controllers
{
    public class EmployeeController :Controller
    {
        private readonly IEployeeService _employee;

        public EmployeeController(IEployeeService employee)
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
