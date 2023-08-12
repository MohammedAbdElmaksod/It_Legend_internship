using Bl.Data;
using Domains.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext _context;

        public BlogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Blogs> GetAllBlogs()
        {
            return _context.TbBlogs.ToList();
        }

        public Blogs GetBlogById(int id)
        {
            if (id > 0)
            {
                return _context.TbBlogs.Find(id);
            }
            return new Blogs();
        }
    }
}
