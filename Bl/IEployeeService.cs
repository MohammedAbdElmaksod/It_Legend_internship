using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IEployeeService
    {
        List<Employees> GetAllEmployees();
        Employees GetEmployeeById(int id);
        Task<Employees> AddEmployee(Employees employee);
    }
}
