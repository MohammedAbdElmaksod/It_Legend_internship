using Bl.Data;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class EmployeeService : IEployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Employees> AddEmployee(Employees employee)
        {
            if (employee == null) throw new ArgumentNullException();
            else
            {
                await _context.TbEmplyees.AddAsync(employee);
                _context.SaveChanges();
                return employee;
            }
        }

        public List<Employees> GetAllEmployees()
        {
            return _context.TbEmplyees.ToList();
        }

        public Employees GetEmployeeById(int id)
        {
            if(id > 0)
            {
                return _context.TbEmplyees.Where(c=>c.companyCategories.Id==c.companyCategoriesId).SingleOrDefault(i=>i.Id==id);
            }
            return new Employees();
        }
    }
}
