using Bl.Data;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class Candidateservice : IService<Candidates>
    {
        private readonly ApplicationDbContext _context;

        public Candidateservice(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Candidates t)
        {
            await _context.TbCandidates.AddAsync(t);
            _context.SaveChanges();
        }

        public List<Candidates> GetAll()
        {
            return _context.TbCandidates.ToList();
        }

        public List<Candidates> GetAll(int pageNum,int pageSize)
        {
            return _context.TbCandidates.Skip(pageNum * pageSize - pageSize).Take(pageSize).ToList();

        }

        public List<Candidates> GetByCategory(int catId)
        {
            return _context.TbCandidates.Where(c=>c.categoryId== catId).ToList();
        }

        public Candidates GetById(int id)
        {
            return _context.TbCandidates.Find(id);
        }

        public List<Candidates> GetRelatedJobs(int KindId)
        {
            throw new NotImplementedException();
        }

        public int totalCount()
        {
            return _context.TbCandidates.Count();
        }
    }
}
