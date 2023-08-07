using Bl.Data;
using Domains;
using Domains.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class JobServices : IService<Jobs>
    {
        private readonly ApplicationDbContext _context;

        public JobServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(Jobs job)
        {
            try
            {
            _context.TbJobs.Add(job);
            _context.SaveChanges();
            return Task.CompletedTask;

            }
            catch (Exception ex) { return Task.FromException(ex); }
        }

        public List<Jobs> GetAll()
        {
            try
            {
                return _context.TbJobs.ToList();

            }
            catch (Exception ex) { return new List<Jobs>(); }
        }

        public List<Jobs> GetByCategory(int catId)
        {
            try
            {
                var Jobs = _context.TbJobs.Where(c => c.CategoryId == catId).ToList();
                return Jobs;
            }
            catch (Exception ex) { return new List<Jobs>(); }
        }

        public Jobs GetById(int id)
        {
            try
            {
                if (id > 0)
                {
                    var job = _context.TbJobs.Find(id);
                    if (job is not null)
                    {
                        return job;
                    }
                    return new Jobs();
                }
                return new Jobs();
            }
            catch (Exception ex) { return new Jobs(); }
        }
        public List<Jobs> GetRelatedJobs(int KindId)
        {
            try
            {
                return _context.TbJobs.Where(r => r.KindId == KindId).ToList();
            }
            catch(Exception ex) { return new List<Jobs>(); }
        }


    }
}
