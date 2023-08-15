using Bl.Data;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class CategoryServices : IService<Categories>
    {
        private readonly ApplicationDbContext _context;

        public CategoryServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(Categories category)
        {
            _context.TbCategory.Add(category);
            _context.SaveChanges();
            return Task.CompletedTask;
        }


        public List<Categories> GetAll()
        {
            return _context.TbCategory.ToList();
        }

        public Categories GetById(int id)
        {
            if (id > 0)
            {
                var category = _context.TbCategory.Find(id);
                if (category is not null)
                {
                    return category;
                }
                return new Categories();
            }
            return new Categories();
        }
        public List<Categories> GetByCategory(int catId)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetRelatedJobs(int KindId)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll(int pageNum, int pageSize)
        {
            return new List<Categories>();
        }

        public int totalCount()
        {
            return _context.TbCategory.Count();
        }
    }
}
