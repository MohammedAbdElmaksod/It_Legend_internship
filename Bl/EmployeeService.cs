using Bl.Data;
using Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public async Task EditEmployee(Employees employee)
        {
            if (employee == null) throw new ArgumentNullException();
            _context.Entry(employee).State = EntityState.Modified;
            
            _context.SaveChanges();
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
        public List<Employees> GetAll(int pageNum,int pageSize)
        {
            return _context.TbEmplyees.Skip(pageNum*pageSize - pageSize).Take(pageSize).ToList();
        }
        public int totalCount()
        {
            return _context.TbEmplyees.Count();
        }
    }
}
